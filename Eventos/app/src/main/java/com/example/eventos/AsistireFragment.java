package com.example.eventos;


import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.eventos.API.API;
import com.example.eventos.API.APIServices.AssistirService;
import com.example.eventos.API.APIServices.EventosService;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class AsistireFragment extends Fragment {

    ArrayList<Assistir> llistaAssistir = new ArrayList<>();
    ArrayList<Event> llistaEvents = new ArrayList<>();
    RecyclerView recycler;
    Activity activity;
    Soci soci;



    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        final View vista = inflater.inflate(R.layout.fragment_asistire,container,false);
        llistaAssistir = new ArrayList<Assistir>();
        recycler = (RecyclerView) vista.findViewById(R.id.recycler);



        //Aquesta linea es momentanea ja que encara no llegim de la API
        OmplirLlista();


        return vista;
    }
    //Métode provisional
    private void OmplirLlista() {

        soci = Login_Activity.getSoci();
        int id_soci = soci.getId();
        AssistirService assistirService = API.getApi().create(AssistirService.class);
        Call<List<Assistir>> listCall = assistirService.getMisEventos(id_soci);

        listCall.enqueue(new Callback<List<Assistir>>() {
            @Override
            public void onResponse(Call<List<Assistir>> call, Response<List<Assistir>> response) {

                switch(response.code()){

                    case 200:

                        llistaAssistir = (ArrayList<Assistir>) response.body();

                        llistaEvents = convertir(llistaAssistir);

                        AdapterEvents adapter = new AdapterEvents(llistaEvents);

                        adapter.setOnClickListener(new View.OnClickListener() {
                            @Override
                            public void onClick(View v) {

                                //Toast.makeText(getContext(),"-" + llistaEvents.get(recycler.getChildAdapterPosition(v)).getNom(),Toast.LENGTH_SHORT).show();

                                //iComunicaFragments.enviarEvent(llistaEvents.get(recycler.getChildAdapterPosition(v)));

                                Intent intent = new Intent(getActivity(),Valorar_Activity.class);
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
            public void onFailure(Call<List<Assistir>> call, Throwable t) {

                Toast.makeText(getContext(),t.getMessage(),Toast.LENGTH_LONG).show();


            }
        });

    }
    public ArrayList<Event> convertir(ArrayList<Assistir> listaAssistir){

        ArrayList<Event> listaEvents= new ArrayList<>();

        for(int i = 0;i<listaAssistir.size();i++){

            listaEvents.add(listaAssistir.get(i).getEsdeveniments());
        }


        return listaEvents;

    }
}

