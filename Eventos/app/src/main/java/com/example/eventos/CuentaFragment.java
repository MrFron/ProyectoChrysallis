package com.example.eventos;


import android.content.Intent;
import android.database.Cursor;
import android.net.Uri;
import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import android.provider.MediaStore;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;

import static android.app.Activity.RESULT_OK;


/**
 * A simple {@link Fragment} subclass.
 */
public class CuentaFragment extends Fragment{

    private String url;
    Button comunidades, contacto,cerrar;
    TextView numSoci,nomSoci;
    ImageButton fotoPerfil;
    private static final int GALERY_REQUEST_CODE = 123;
    private static final int PICK_IMAGE = 100;
    Uri imageUri;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {

        View vista = inflater.inflate(R.layout.fragment_cuenta,container,false);

        fotoPerfil = (ImageButton) vista.findViewById(R.id.imatge);
        cerrar = (Button) vista.findViewById(R.id.cerrarsesion);
        nomSoci = (TextView) vista.findViewById(R.id.nomSoci);
        numSoci = (TextView) vista.findViewById(R.id.numSoci);
        contacto = (Button) vista.findViewById(R.id.buttonContactoCuenta);
        comunidades = (Button) vista.findViewById(R.id.ButtonComunidades);
        url = "https://chrysallis.org.es/contacto/";



        Soci soci = Login_Activity.getSoci();
        numSoci.setText(" " + soci.getId());
        nomSoci.setText(soci.getNom() + " " + soci.getCognoms());



        fotoPerfil.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {


                openGallery();
            }

            private void openGallery(){
                Intent gallery = new Intent(Intent.ACTION_PICK, MediaStore.Images.Media.INTERNAL_CONTENT_URI);
                startActivityForResult(gallery, PICK_IMAGE);
            }
        });

        cerrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getContext(),Login_Activity.class);
                startActivity(intent);
            }
        });
        comunidades.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intent = new Intent(getActivity(),SeleccioComunitats_Activity.class);
                startActivity(intent);

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




        return vista;
    }

    @Override
    public void onActivityResult(int requestCode, int resultCode, Intent data){
        if(resultCode == RESULT_OK && requestCode == PICK_IMAGE){
            imageUri = data.getData();
            fotoPerfil.setImageURI(imageUri);
        }
    }
}
