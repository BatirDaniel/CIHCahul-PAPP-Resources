package com.example.elementminimalapp;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        EditText editNumber = findViewById(R.id.editNumber);
        Button btnDetermina = findViewById(R.id.btnDetermina);

        Intent intent = new Intent(MainActivity.this, ResultActivity.class);

        try {
            int number = Integer.parseInt(editNumber.getText().toString());
            intent.putExtra("number", number);
            btnDetermina.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    startActivity(intent);
                    editNumber.setText(0);
                }
            });
        }catch(NumberFormatException err){
            Toast.makeText(MainActivity.this, "Introduceți un număr valid", Toast.LENGTH_SHORT).show();
        }
    }
}