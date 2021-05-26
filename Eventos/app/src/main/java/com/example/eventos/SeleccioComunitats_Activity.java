package com.example.eventos;

import android.content.Intent;
import android.os.Bundle;
import android.util.SparseBooleanArray;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;
import java.util.List;

public class SeleccioComunitats_Activity extends AppCompatActivity implements View.OnClickListener {

    ListView listViewComunitatas;
    Button Acceptar;

    String[] Comunitats = {"Andalucía", "Canarias", "Cantabria", "Cataluña", "Galicia", "Islas Baleares","La Rioja", "Navarra" , "País Vasco" , "Aragón", "Castilla-La Mancha", "Castilla y León", "Comunidad Valenciana", "Extremadura", "Comunidad de Madrid" , "Región de Murcia"};
    Integer[] ids = {1, 5, 6, 9, 12, 4,13,16,17 , 2, 7, 8, 10, 11, 14, 15};


    List<String> LlistaSeleccionats;
    ArrayList<Integer> LlistaID;





    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.selecio_comunitats);

        listViewComunitatas = (ListView) findViewById(R.id.list);
        Acceptar = (Button) findViewById(R.id.buttonAceptar);

        Acceptar.setOnClickListener(this);


        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,android.R.layout.simple_list_item_multiple_choice,Comunitats);
        listViewComunitatas.setAdapter(adapter);


    }

    @Override
    public void onClick(View v) {

        switch(v.getId()){
            case R.id.buttonAceptar:
                LlistaSeleccionats =new ArrayList<>();
                LlistaID = new ArrayList<>();
                SparseBooleanArray itemChecked = listViewComunitatas.getCheckedItemPositions();
                for(int i = 0;i<itemChecked.size();i++){
                    int clau = itemChecked.keyAt(i);
                    boolean estat = itemChecked.get(clau);
                    if (estat){
                        LlistaSeleccionats.add(listViewComunitatas.getItemAtPosition(clau).toString());
                        LlistaID.clear();
                        for(int j =0;j < LlistaSeleccionats.size(); j++){

                            String comunitat = LlistaSeleccionats.get(j);

                            for(int k = 0; k < Comunitats.length; k++){



                                if(Comunitats[k].equals(comunitat)){

                                    LlistaID.add(ids[k]);
                                }

                            }
                        }
                    }
                }



                if(LlistaSeleccionats.isEmpty()){
                    Toast.makeText(getApplicationContext(),"¿No te interesa ninguna Comunidad?",Toast.LENGTH_LONG).show();
                }else{
                    Toast.makeText(getApplicationContext(),"Comunidades seleccionadas" + LlistaSeleccionats,Toast.LENGTH_LONG).show();

                }

                Intent intent = new Intent(SeleccioComunitats_Activity.this,MainActivity.class);
                intent.putExtra("ids", LlistaID);
                startActivity(intent);

                break;


        }

    }
}
