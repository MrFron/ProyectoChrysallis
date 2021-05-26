package com.example.eventos;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import com.example.eventos.API.API;
import com.example.eventos.API.APIServices.ComunitatService;
import com.example.eventos.API.APIServices.SociService;

import java.io.Serializable;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class Login_Activity extends AppCompatActivity{

    private String url;
    Button acceder, contacto;
    static Soci soci;
    boolean validat = false;
    EditText tel, psw;


    public static  Soci getSoci() {
        return soci;
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);


        url = "https://chrysallis.org.es/contacto/";

        contacto = (Button) findViewById(R.id.ButtonContacto);
        tel = (EditText) findViewById(R.id.txtTel);
        psw = (EditText) findViewById(R.id.txtPsw);

        acceder = (Button) findViewById(R.id.acceder);
        acceder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                SociService sociService = API.getApi().create(SociService.class);

                Call<Soci> listCall = sociService.getValidacio(tel.getText().toString());

                listCall.enqueue(new Callback<Soci>() {
                    @Override
                    public void onResponse(Call<Soci> call, Response<Soci> response) {

                        switch(response.code()){

                            case 200:

                                soci = response.body();



                                String passwordToHash = psw.getText().toString();
                                String generatedPassword = null;
                                try {
                                    // Create MessageDigest instance for MD5
                                    MessageDigest md = MessageDigest.getInstance("SHA-512");
                                    //Add password bytes to digest
                                    md.update(passwordToHash.getBytes());
                                    //Get the hash's bytes
                                    byte[] bytes = md.digest();
                                    //This bytes[] has bytes in decimal format;
                                    //Convert it to hexadecimal format
                                    StringBuilder sb = new StringBuilder();
                                    for(int i=0; i< bytes.length ;i++)
                                    {
                                        sb.append(Integer.toString((bytes[i] & 0xff) + 0x100, 16).substring(1));
                                    }
                                    //Get complete hashed password in hex format
                                    generatedPassword = sb.toString();
                                    String pas = generatedPassword.toUpperCase();

                                    if(pas.equals(soci.getContrasenya())){

                                        validat = true;

                                    }else {

                                        validat = false;
                                    }
                                }catch (NoSuchAlgorithmException e){

                                    e.printStackTrace();
                                }

                                if (validat == true){

                                    if(soci.getActiu() == true) {
                                        Intent intent = new Intent(Login_Activity.this, SeleccioComunitats_Activity.class);
                                        startActivity(intent);
                                    }else{

                                        Toast.makeText(Login_Activity.this,"Cuenta NO activa",Toast.LENGTH_LONG).show();

                                    }
                                }else{

                                    Toast.makeText(Login_Activity.this,"Contraseña incorrecta",Toast.LENGTH_LONG).show();
                                }


                                break;
                            case 400:
                                Toast.makeText(Login_Activity.this,"Introduzca teléfono y contraseña",Toast.LENGTH_LONG).show();
                                break;
                            case 500:
                                Toast.makeText(Login_Activity.this,"code 500",Toast.LENGTH_LONG).show();
                                break;
                            case 503:
                                Toast.makeText(Login_Activity.this,"code 503",Toast.LENGTH_LONG).show();
                                break;
                            default:
                                Toast.makeText(Login_Activity.this,"El telefono o contraseña son incorrectos",Toast.LENGTH_LONG).show();
                        }
                    }

                    @Override
                    public void onFailure(Call<Soci> call, Throwable t) {

                        Toast.makeText(Login_Activity.this,t.getMessage(),Toast.LENGTH_LONG).show();

                    }
                });




            }
        });

        contacto.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Uri uri = Uri.parse(url);
                Intent intent = new Intent( Intent.ACTION_VIEW,uri);
                startActivity(intent);
            }
        });


    }

}
