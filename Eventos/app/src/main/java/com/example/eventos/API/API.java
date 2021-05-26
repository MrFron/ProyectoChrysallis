package com.example.eventos.API;

import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;


public class API {

    private static final String BASE_URL = "http://192.168.1.157:54509/";
    private static Retrofit retrofit = null;

    public static Retrofit getApi() {
        if (retrofit == null) {
            retrofit = new Retrofit.Builder().baseUrl(BASE_URL).addConverterFactory(GsonConverterFactory.create()).build();

        }
        return retrofit;
    }
}



