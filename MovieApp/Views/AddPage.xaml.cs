using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Models;

namespace MovieApp.Views;

public partial class AddPage : ContentPage
{
    public AddPage()
    {
        InitializeComponent();
        Title = "Add New Movie";
    }

    private void AddMovie_OnClicked(object sender, EventArgs e)
    {
        var newMovie = new Movie();
        newMovie.Title = txtTitle.Text;
        newMovie.Rating = txtRating.Text;
        
        App.MovieList.SaveMovie(newMovie); // Save to database

        txtTitle.Text = "";
        txtRating.Text = "";
    }
}