from django.urls import path
from . import views


urlpatterns = [
    path('', views.Cocktail_home, name='CocktailRecipesHome'),
    path('create', views.Cocktail_create, name='CocktailRecipesCreate')
]