from django.shortcuts import render, redirect
from .models import Cocktail
from .forms import CocktailForm


def Cocktail_home(request):
    return render(request, 'CocktailRecipesApp/CocktailRecipes_Home.html')


def Cocktail_create(request):
    form = CocktailForm(request.POST)
    if request.method == 'POST':
        if form.is_valid():
            form.save()
            return redirect('CocktailRecipesHome')
    content = {'form': form}
    return render(request, 'CocktailRecipesApp/CocktailRecipes_Create.html', content)
