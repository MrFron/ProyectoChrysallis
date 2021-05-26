package com.example.eventos;

public class Assistir {


    private Event esdeveniments;
    private int id_soci;
    private int id_esdeveniment;
    private int num_familiars;
    private int valoració;
    private String comentari;

    public Assistir(Event esdeveniments, int id_soci, int id_esdeveniment, int num_familiars, int valoració, String comentari) {

        this.esdeveniments = esdeveniments;
        this.id_soci = id_soci;
        this.id_esdeveniment = id_esdeveniment;
        this.num_familiars = num_familiars;
        this.valoració = valoració;
        this.comentari = comentari;
    }

    public Assistir(int id_soci, int id_esdeveniment, int num_familiars, int valoració, String comentari) {

        this.id_soci = id_soci;
        this.id_esdeveniment = id_esdeveniment;
        this.num_familiars = num_familiars;
        this.valoració = valoració;
        this.comentari = comentari;
    }

    public Event getEsdeveniments() {
        return esdeveniments;
    }

    public void setEsdeveniments(Event esdeveniments) {
        this.esdeveniments = esdeveniments;
    }

    public int getId_soci() {
        return id_soci;
    }

    public void setId_soci(int id_soci) {
        this.id_soci = id_soci;
    }

    public int getId_esdeveniment() {
        return id_esdeveniment;
    }

    public void setId_esdeveniment(int id_esdeveniment) {
        this.id_esdeveniment = id_esdeveniment;
    }

    public int getNum_familiars() {
        return num_familiars;
    }

    public void setNum_familiars(int num_familiars) {
        this.num_familiars = num_familiars;
    }

    public int getValoració() {
        return valoració;
    }

    public void setValoració(int valoració) {
        this.valoració = valoració;
    }

    public String getComentari() {
        return comentari;
    }

    public void setComentari(String comentari) {
        this.comentari = comentari;
    }
}
