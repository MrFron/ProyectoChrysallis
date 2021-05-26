package com.example.eventos;

import java.io.Serializable;

public class Event implements Serializable {


    private int id;
    private String data;
    private String hora;
    private String ubicació;
    private String data_limit;
    private int id_comunitat;
    private String descripcio;
    private String nom;
    private String img;


    public Event(int id, String data, String hora, String ubicació, String data_limit, int id_comunitat, String descripcio, String nom, String img) {
        this.id = id;
        this.data = data;
        this.hora = hora;
        this.ubicació = ubicació;
        this.data_limit = data_limit;
        this.id_comunitat = id_comunitat;
        this.descripcio = descripcio;
        this.nom = nom;
        this.img = img;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getData() {
        return data;
    }

    public void setData(String data) {
        this.data = data;
    }

    public String getHora() {
        return hora;
    }

    public void setHora(String hora) {
        this.hora = hora;
    }

    public String getUbicació() {
        return ubicació;
    }

    public void setUbicació(String ubicació) {
        this.ubicació = ubicació;
    }

    public String getData_limit() {
        return data_limit;
    }

    public void setData_limit(String data_limit) {
        this.data_limit = data_limit;
    }

    public int getId_comunitat() {
        return id_comunitat;
    }

    public void setId_comunitat(int id_comunitat) {
        this.id_comunitat = id_comunitat;
    }

    public String getDescripcio() {
        return descripcio;
    }

    public void setDescripcio(String descripcio) {
        this.descripcio = descripcio;
    }

    public String getImg() {
        return img;
    }

    public void setImg(String img) {
        this.img = img;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
}
