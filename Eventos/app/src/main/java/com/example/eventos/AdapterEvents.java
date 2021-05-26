package com.example.eventos;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.util.Base64;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class AdapterEvents extends RecyclerView.Adapter<AdapterEvents.PersonajeViewHolder> implements View.OnClickListener{

    ArrayList<Event> listaEvents;
    private View.OnClickListener listener;

    public AdapterEvents(ArrayList<Event> listaEvents) {
        this.listaEvents=listaEvents;
    }

    @Override
    public PersonajeViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View view= LayoutInflater.from(parent.getContext()).inflate(R.layout.item_event,null,false);
        view.setOnClickListener(this);
        return new PersonajeViewHolder(view);
    }

    @Override
    public void onBindViewHolder(PersonajeViewHolder holder, int position) {
        holder.txtNombre.setText(listaEvents.get(position).getNom());

        StringBuilder sb = new StringBuilder(listaEvents.get(position).getData());
        sb.setLength(10);
        String data = sb.toString();
        holder.txtInformacion.setText("- " + data + "\n" + "- " + listaEvents.get(position).getUbicació());


        byte[] imatge = Base64.decode(listaEvents.get(position).getImg(), Base64.DEFAULT);
        Bitmap bmp = BitmapFactory.decodeByteArray(imatge, 0, imatge.length);
        holder.foto.setImageBitmap(bmp);

    }

    @Override
    public int getItemCount() {
        return listaEvents.size();
    }

    public void setOnClickListener(View.OnClickListener listener){

        this.listener = listener;

    }

    @Override
    public void onClick(View v) {

        if(listener != null){
            listener.onClick(v);
        }
    }

    public class PersonajeViewHolder extends RecyclerView.ViewHolder {
        TextView txtNombre,txtInformacion;
        ImageView foto;

        public PersonajeViewHolder(View itemView) {
            super(itemView);
            txtNombre= (TextView) itemView.findViewById(R.id.nom);
            txtInformacion= (TextView) itemView.findViewById(R.id.descripcio);
            foto= (ImageView) itemView.findViewById(R.id.imatge);
        }
    }
}
