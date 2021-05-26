package com.example.eventos;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import android.os.Bundle;
import android.view.MenuItem;
import android.widget.FrameLayout;

import com.google.android.material.bottomnavigation.BottomNavigationView;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity implements IComunicaFragments{

    private BottomNavigationView bottomNavigationView;
    private FrameLayout frameLayout;

    private AsistireFragment asistireFragment;
    private NotificacionesFragment notificacionesFragment;
    private CuentaFragment cuentaFragment;
    private InicioFragment inicioFragment;
    DetallFragment detallFragment;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ArrayList<Integer> comunitats = (ArrayList<Integer>) getIntent().getSerializableExtra("ids");
        inicioFragment = new InicioFragment(comunitats);
        cuentaFragment = new CuentaFragment();
        notificacionesFragment = new NotificacionesFragment();



        bottomNavigationView = (BottomNavigationView) findViewById(R.id.bottom_navigation);
        frameLayout = (FrameLayout) findViewById(R.id.FrameLayout);

        if(savedInstanceState == null){
            getSupportFragmentManager().beginTransaction().replace(R.id.FrameLayout,inicioFragment).commit();
        }


        bottomNavigationView.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem menuItem) {

                Fragment fragment = null;

                switch (menuItem.getItemId()){
                    case R.id.inicio:

                        fragment = new InicioFragment(comunitats);
                        break;

                    case R.id.Cuenta:

                        fragment = new CuentaFragment();
                        break;

                    case R.id.Notificaciones:

                        fragment = new NotificacionesFragment();
                        break;

                    case R.id.MisEventos:

                        fragment = new AsistireFragment();
                        break;

                }


                getSupportFragmentManager().beginTransaction().replace(R.id.FrameLayout,fragment).commit();
                return true;
            }
        });
    }

    @Override
    public void enviarEvent(Event event) {
        detallFragment = new DetallFragment();
        Bundle bundle = new Bundle();
        bundle.putSerializable("objeto",event);
        detallFragment.setArguments(bundle);
        getSupportFragmentManager().beginTransaction().replace(R.id.FrameLayout,detallFragment).addToBackStack(null).commit();
    }
}
