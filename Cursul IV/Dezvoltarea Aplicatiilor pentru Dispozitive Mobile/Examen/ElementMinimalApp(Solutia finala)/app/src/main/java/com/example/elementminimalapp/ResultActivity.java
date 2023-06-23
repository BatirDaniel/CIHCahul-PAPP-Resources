package com.example.elementminimalapp;

import static java.util.Arrays.*;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Random;
import java.util.Vector;

public class ResultActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_result);

        TextView txtVector = findViewById(R.id.txtVector);
        TextView txtPositionMinElement = findViewById(R.id.txtPositionMin);
        Button btnHome = findViewById(R.id.btnHome);

        Intent intent = getIntent();
        int number = intent.getIntExtra("number",0);

        Random rnd = new Random();
        int[] vector = new int[number];
        for(int i = 0; i < vector.length;i++){
            vector[i] = rnd.nextInt();
            String item = String.valueOf(vector[1]);
            txtVector.append(item);
        }

        int min = vector[0];
        for(int i = 0; i < vector.length;i++){
            if(vector[i] < min){
                min = vector[i];
            }
        }

        int position = Arrays.asList(vector).indexOf(min);
        txtPositionMinElement.setText(position + "");

        Intent newIntent = new Intent(this, MainActivity.class);

        btnHome.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(newIntent);
            }
        });
    }
}