package com.example.eventos.API.APIServices;

import com.example.eventos.Event;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Path;

public interface EventosService {

    @GET("api/esdeveniments")
    Call<List<Event>> getEsdeveniments();

    @GET("api/esdeveniments/esdByComunitat/{comunitat}")
    Call<List<Event>> getEventos( @Path( "comunitat" ) int comunitat );


}
