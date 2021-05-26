package com.example.eventos;


import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.DividerItemDecoration;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import com.example.eventos.API.API;
import com.example.eventos.API.APIServices.ComunitatService;
import com.example.eventos.API.APIServices.EventosService;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;


/**
 * A simple {@link Fragment} subclass.
 */



public class InicioFragment extends Fragment {

    ArrayList<Event> llistaEvents = new ArrayList<>();
    ArrayList<Comunitat> llistaComunitats = new ArrayList<>();
    RecyclerView recycler;
    IComunicaFragments iComunicaFragments;
    Activity activity;
    ArrayList<Integer> ids;
    private static ArrayList<Integer> ID = new ArrayList<>();

    public InicioFragment(ArrayList<Integer> ids) {
        this.ids = ids;
    }

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {

        final View vista = inflater.inflate(R.layout.fragment_inicio,container,false);
        llistaComunitats = new ArrayList<>();
        llistaEvents = new ArrayList<Event>();
        recycler = (RecyclerView) vista.findViewById(R.id.recycler);

        //Aquesta linea es momentanea ja que encara no llegim de la API
        OmplirLlista();


        return vista;

    }



    //Métode provisional
    private void OmplirLlista() {

        if(ids != null) {
            ID = ids;
        }

        ComunitatService comunitatService = API.getApi().create(ComunitatService.class);

        Call<List<Comunitat>> listCall = comunitatService.getComunitatEsdeveniments(ID);

        listCall.enqueue(new Callback<List<Comunitat>>() {
            @Override
            public void onResponse(Call<List<Comunitat>> call, Response<List<Comunitat>> response) {

                switch(response.code()){

                    case 200:
                        
                        llistaComunitats = (ArrayList<Comunitat>) response.body();
                        llistaEvents = convertir(llistaComunitats);


                        AdapterEvents adapter = new AdapterEvents(llistaEvents);

                        adapter.setOnClickListener(new View.OnClickListener() {
                            @Override
                            public void onClick(View v) {



                                //Toast.makeText(getContext(),"-" + llistaEvents.get(recycler.getChildAdapterPosition(v)).getNom(),Toast.LENGTH_SHORT).show();

                                //iComunicaFragments.enviarEvent(llistaEvents.get(recycler.getChildAdapterPosition(v)));

                                Intent intent = new Intent(getActivity(),Detall_Activity.class);
                                startActivity(intent);

                                Event obj = llistaEvents.get(recycler.getChildAdapterPosition(v));

                                intent.putExtra("Objeto", (Serializable) obj);


                                startActivity(intent);

                            }
                        });

                        recycler.setLayoutManager(new LinearLayoutManager(getContext()));
                        recycler.setAdapter(adapter);

                        break;
                    case 400:
                        Toast.makeText(getContext(),"La respuesta es incorrecta",Toast.LENGTH_LONG).show();
                        break;
                    case 500:
                        Toast.makeText(getContext(),"code 500",Toast.LENGTH_LONG).show();
                        break;
                    case 503:
                        Toast.makeText(getContext(),"code 503",Toast.LENGTH_LONG).show();
                        break;
                    default:
                        Toast.makeText(getContext(),"Error",Toast.LENGTH_LONG).show();
                }
            }

            @Override
            public void onFailure(Call<List<Comunitat>> call, Throwable t) {

                Toast.makeText(getContext(),t.getMessage(),Toast.LENGTH_LONG).show();


            }
        });

    }
    @Override
    public void onAttach(Context context) {
        super.onAttach(context);
        if(context instanceof Activity) {
            this.activity = (Activity) context;
            iComunicaFragments = (IComunicaFragments) this.activity;
        }
    }

    public ArrayList<Event> convertir(ArrayList<Comunitat> llistaComunitats){

        ArrayList<Event> listaEvents= new ArrayList<>();

        for(Comunitat comunitat: llistaComunitats){

            for(Event event: comunitat.getEsdeveniment()){


                listaEvents.add(event);
            }

        }


        return listaEvents;
    }

}


