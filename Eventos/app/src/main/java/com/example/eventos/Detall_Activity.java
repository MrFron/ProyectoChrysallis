package com.example.eventos;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.net.Uri;
import android.os.Bundle;
import android.text.method.ScrollingMovementMethod;
import android.util.Base64;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import com.example.eventos.API.API;
import com.example.eventos.API.APIServices.AssistirService;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class Detall_Activity extends AppCompatActivity implements View.OnClickListener {

    Button Assistir;
    ImageButton ubi;
    TextView titol, descripcio, descrip;
    ImageView img;
    Spinner spinner;
    static int num_fam;

    public static int getNum_fam() {
        return num_fam;
    }

    private final static Integer[] names = {0, 1, 2, 3, 4, 5};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.detall_activity);

        ArrayAdapter adapter1 = new ArrayAdapter<Integer>(this,android.R.layout.simple_spinner_dropdown_item, names);
        spinner = (Spinner) findViewById(R.id.spinner);
        spinner.setAdapter(adapter1);

        descrip = (TextView) findViewById(R.id.TVDescripcio);
        ubi = (ImageButton) findViewById(R.id.buttonUbicacio);
        titol = (TextView) findViewById(R.id.textViewTitol);
        descripcio = (TextView) findViewById(R.id.textViewInfo);
        img = (ImageView) findViewById(R.id.imageViewImg);
        Assistir = (Button) findViewById(R.id.button);
        final Event e = (Event) getIntent().getSerializableExtra("Objeto");


        Assistir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Soci soci = Login_Activity.getSoci();
                num_fam = Integer.parseInt(spinner.getSelectedItem().toString());

                Assistir assistir = new Assistir(soci.getId(),e.getId(),Integer.parseInt(spinner.getSelectedItem().toString()),0,null);

                AssistirService assistirService = API.getApi().create(AssistirService.class);
                Call<Assistir> listCall = assistirService.postAssistir(assistir);

                listCall.enqueue(new Callback<Assistir>() {
                    @Override
                    public void onResponse(Call<Assistir> call, Response<Assistir> response) {

                        switch(response.code()){

                            case 201:

                                Toast.makeText(getApplicationContext(),"Evento añadido a Mis Eventos",Toast.LENGTH_LONG).show();

                                Intent intent = new Intent(Detall_Activity.this,MainActivity.class);
                                startActivity(intent);

                                break;
                            case 400:
                                Toast.makeText(Detall_Activity.this,"La respuesta es incorrecta",Toast.LENGTH_LONG).show();
                                break;
                            case 500:
                                Toast.makeText(Detall_Activity.this,"code 500",Toast.LENGTH_LONG).show();
                                break;
                            case 503:
                                Toast.makeText(Detall_Activity.this,"code 503",Toast.LENGTH_LONG).show();
                                break;
                            default:
                                Toast.makeText(Detall_Activity.this,"Ya estás apuntado en este evento",Toast.LENGTH_LONG).show();

                                Intent hola = new Intent(Detall_Activity.this,MainActivity.class);
                                startActivity(hola);
                        }
                    }

                    @Override
                    public void onFailure(Call<Assistir> call, Throwable t) {

                        Toast.makeText(Detall_Activity.this,t.getMessage(),Toast.LENGTH_LONG).show();


                    }
                });



            }
        });

        ubi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Uri gmmIntentUri = Uri.parse("geo:0,0?z=10&q=" + e.getUbicació());
                Intent mapIntent = new Intent(Intent.ACTION_VIEW, gmmIntentUri);
                mapIntent.setPackage("com.google.android.apps.maps");
                startActivity(mapIntent);

            }
        });



        titol.setText(e.getNom());

        StringBuilder sb = new StringBuilder(e.getData());
        sb.setLength(10);
        String data = sb.toString();


        StringBuilder hola = new StringBuilder(e.getData_limit());
        hola.setLength(10);
        String data_limit = hola.toString();

        StringBuilder hola1 = new StringBuilder(e.getHora());
        hola1.setLength(5);
        String hora = hola1.toString();

        descripcio.setText("Dia: " + data +
                "\nHora: " + hora + " h \n" + "Fecha limite: " + data_limit + "\nUbicación: " + e.getUbicació());
        byte[] imatge = Base64.decode(e.getImg(), Base64.DEFAULT);
        Bitmap bmp = BitmapFactory.decodeByteArray(imatge, 0, imatge.length);
        img.setImageBitmap(bmp);
        descrip.setText(e.getDescripcio());
    }

    @Override
    public void onClick(View v) {


        //Aqui s'haurà d'obrir el fitxer clicat.

    }
}
