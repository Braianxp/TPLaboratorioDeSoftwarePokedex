PGDMP     *                    {            Pokedex    15.0    15.0 
               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    24716    Pokedex    DATABASE     |   CREATE DATABASE "Pokedex" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Spanish_Spain.1252';
    DROP DATABASE "Pokedex";
                postgres    false            �            1259    24750 
   entrenador    TABLE     �   CREATE TABLE public.entrenador (
    id uuid NOT NULL,
    nombre character varying,
    origen character varying,
    liderdegimnasio boolean,
    medallas integer
);
    DROP TABLE public.entrenador;
       public         heap    postgres    false            �            1259    24769    entrenador_pokemon    TABLE     l   CREATE TABLE public.entrenador_pokemon (
    id uuid NOT NULL,
    identrenador uuid,
    idpokemon uuid
);
 &   DROP TABLE public.entrenador_pokemon;
       public         heap    postgres    false            �            1259    24738    pokemon    TABLE     �   CREATE TABLE public.pokemon (
    id uuid NOT NULL,
    nombre character varying,
    orden integer,
    tipo character varying,
    evolucion character varying,
    habilidad character varying
);
    DROP TABLE public.pokemon;
       public         heap    postgres    false            o           2606    24756    entrenador entrenador_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.entrenador
    ADD CONSTRAINT entrenador_pkey PRIMARY KEY (id);
 D   ALTER TABLE ONLY public.entrenador DROP CONSTRAINT entrenador_pkey;
       public            postgres    false    215            q           2606    24773 *   entrenador_pokemon entrenador_pokemon_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public.entrenador_pokemon
    ADD CONSTRAINT entrenador_pokemon_pkey PRIMARY KEY (id);
 T   ALTER TABLE ONLY public.entrenador_pokemon DROP CONSTRAINT entrenador_pokemon_pkey;
       public            postgres    false    216            m           2606    24744    pokemon pokemon_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.pokemon
    ADD CONSTRAINT pokemon_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.pokemon DROP CONSTRAINT pokemon_pkey;
       public            postgres    false    214           