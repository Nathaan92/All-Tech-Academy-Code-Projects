from django.shortcuts import render, redirect
from .forms import TheBigOneForm
from .forms import TheContactForm


def home(request):
    return render(request, 'CatchIdentificationApp/CatchIdentification_Home.html')


def contact(request):
    form = TheContactForm(request.POST or None)
    if request.method == 'POST':
        if form.is_valid():
            form.save()
            return redirect('CatchIdentificationAppHome')
    context = {'form': form, }
    return render(request, 'CatchIdentificationApp/CatchIdentification_Contact.html', context)


def catchLog(request):
    form = TheBigOneForm(request.POST or None)
    if request.method == 'POST':
        if form.is_valid():
            form.save()
            return redirect('CatchIdentificationAppHome')
    context = {'form': form, }
    return render(request, 'CatchIdentificationApp/CatchIdentification_BigOne.html', context)
