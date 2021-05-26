package com.example.eventos;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.net.Uri;
import android.os.Bundle;
import android.util.Base64;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.example.eventos.API.API;
import com.example.eventos.API.APIServices.AssistirService;

import okhttp3.ResponseBody;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class Valorar_Activity extends AppCompatActivity {

    Button valorar;
    ImageButton ubi;
    TextView titol, descripcio, descrip;
    ImageView img;
    Spinner spinner;
    EditText comentari;

    private final static Integer[] names = {1, 2, 3, 4, 5,6,7,8,9,10};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_valorar_);

        ArrayAdapter adapter1 = new ArrayAdapter<Integer>(this, android.R.layout.simple_spinner_dropdown_item, names);
        spinner = (Spinner) findViewById(R.id.spinner);
        spinner.setAdapter(adapter1);

        comentari = (EditText) findViewById(R.id.editComentari);
        descrip = (TextView) findViewById(R.id.TVDescripcio);
        ubi = (ImageButton) findViewById(R.id.buttonUbicacio);
        titol = (TextView) findViewById(R.id.textViewTitol);
        descripcio = (TextView) findViewById(R.id.textViewInfo);
        img = (ImageView) findViewById(R.id.imageViewImg);
        valorar = (Button) findViewById(R.id.button);
        final Event e = (Event) getIntent().getSerializableExtra("Objeto");


        valorar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Soci soci = Login_Activity.getSoci();

                Assistir assistir = new Assistir(soci.getId(), e.getId(), Detall_Activity.getNum_fam(), Integer.parseInt(spinner.getSelectedItem().toString()), comentari.getText().toString() );

                AssistirService assistirService = API.getApi().create(AssistirService.class);
                Call<ResponseBody> listCall = assistirService.updateAssistir(soci.getId(),assistir);

                listCall.enqueue(new Callback<ResponseBody>() {
                    @Override
                    public void onResponse(Call<ResponseBody> call, Response<ResponseBody> response) {

                        switch (response.code()) {

                            case 204:

                                Toast.makeText(getApplicationContext(), "Valoración realizada", Toast.LENGTH_LONG).show();

                                Intent intent = new Intent(Valorar_Activity.this, MainActivity.class);
                                startActivity(intent);

                                break;
                            case 400:
                                Toast.makeText(Valorar_Activity.this, "La respuesta es incorrecta", Toast.LENGTH_LONG).show();
                                break;
                            case 500:
                                Toast.makeText(Valorar_Activity.this, "code 500", Toast.LENGTH_LONG).show();
                                break;
                            case 503:
                                Toast.makeText(Valorar_Activity.this, "code 503", Toast.LENGTH_LONG).show();
                                break;
                            default:
                                Toast.makeText(Valorar_Activity.this, "Ya estás apuntado en este evento", Toast.LENGTH_LONG).show();

                                Intent hola = new Intent(Valorar_Activity.this, MainActivity.class);
                                startActivity(hola);
                        }
                    }

                    @Override
                    public void onFailure(Call<ResponseBody> call, Throwable t) {

                        Toast.makeText(Valorar_Activity.this, t.getMessage(), Toast.LENGTH_LONG).show();


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
        descripcio.setText("Dia: " + data +
                "\nHora: " + e.getHora() + "\n" + "Fecha limite: " + data_limit);
        byte[] imatge = Base64.decode(e.getImg(), Base64.DEFAULT);
        Bitmap bmp = BitmapFactory.decodeByteArray(imatge, 0, imatge.length);
        img.setImageBitmap(bmp);
        descrip.setText(e.getDescripcio());

    }
}
