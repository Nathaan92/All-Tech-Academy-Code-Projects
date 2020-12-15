# Generated by Django 2.2.5 on 2020-09-09 01:17

import datetime
from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('SendItApp', '0013_auto_20200904_1957'),
    ]

    operations = [
        migrations.CreateModel(
            name='Attempt',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('date', models.DateField(default=datetime.datetime.now, verbose_name='Date')),
                ('light', models.CharField(blank=True, choices=[('Shade', 'Shade'), ('Sun', 'Sun'), ('Night', 'Night')], default='None', max_length=40, verbose_name='Lighting')),
                ('temp', models.CharField(default='', max_length=20)),
                ('status', models.CharField(blank=True, choices=[('Onsight', 'Onsight'), ('Redpoint', 'Redpoint'), ('Pinkpoint', 'Pinkpoint'), ('To Do', 'To Do'), ('Flash', 'Flash'), ('Flail', 'Flail'), ('Sent', 'Sent')], default='None', max_length=40)),
                ('shoes', models.CharField(blank=True, default='', max_length=40, null=True)),
                ('notes', models.CharField(blank=True, default='', max_length=255, null=True)),
            ],
        ),
        migrations.CreateModel(
            name='Climb',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('type', models.CharField(blank=True, choices=[('Sport', 'Sport'), ('Boulder', 'Boulder'), ('Trad', 'Trad'), ('Alpine', 'Alpine'), ('Ice', 'Ice')], default='None', max_length=30, verbose_name='Type')),
                ('name', models.CharField(default='Name', max_length=40, null=True, verbose_name='Name')),
                ('grade', models.CharField(blank=True, choices=[('5.7', '5.7'), ('5.8', '5.8'), ('5.9', '5.9'), ('5.10a', '5.10a'), ('5.10b', '5.10b'), ('5.10c', '5.10c'), ('5.10d', '5.10d'), ('5.11a', '5.11a'), ('5.11b', '5.11b'), ('5.11c', '5.11c'), ('5.11d', '5.11d'), ('5.12a', '5.12a'), ('5.12b', '5.12b'), ('5.12c', '5.12c'), ('5.12d', '5.12d'), ('5.13a', '5.13a'), ('5.13b', '5.13b'), ('5.13c', '5.13c'), ('5.13d', '5.13d'), ('5.14a', '5.14a'), ('5.14b', '5.14b'), ('5.14c', '5.14c'), ('5.14d', '5.14d'), ('5.15a', '5.15a'), ('5.15b', '5.15b'), ('5.15c', '5.15c'), ('5.15d', '5.15d'), ('V1', 'V1'), ('V2', 'V2'), ('V3', 'V3'), ('V4', 'V4'), ('V5', 'V5'), ('V6', 'V6'), ('V7', 'V7'), ('V8', 'V8'), ('V9', 'V9'), ('V10', 'V10'), ('V11', 'V11'), ('V12', 'V12'), ('V13', 'V13'), ('V14', 'V14'), ('V15', 'V15'), ('WI1', 'WI1'), ('WI1+', 'WI1+'), ('WI2', 'WI2'), ('WI2+', 'WI2+'), ('WI3', 'WI3'), ('WI3+', 'WI3+'), ('WI4', 'WI4'), ('WI4+', 'WI4+'), ('WI5', 'WI5'), ('WI5+', 'WI5+'), ('WI6', 'WI6'), ('WI6+', 'WI6+'), ('WI7', 'WI7'), ('WI7+', 'WI7+')], default='None', max_length=20, verbose_name='Grade')),
                ('pitches', models.PositiveIntegerField(blank=True, default='1', null=True, verbose_name='Pitches')),
                ('rock', models.CharField(blank=True, choices=[('Granite', 'Granite'), ('Limestone', 'Limestone'), ('Quartzite', 'Quartzite'), ('Sandstone', 'Sandstone'), ('Cobble', 'Cobble'), ('Gneiss', 'Gneiss'), ('Unknown', 'Unknown')], default='None', max_length=40, verbose_name='Rock Type')),
                ('image', models.URLField(blank=True, default='', max_length=255, verbose_name='Image')),
            ],
        ),
        migrations.DeleteModel(
            name='Boulder',
        ),
        migrations.DeleteModel(
            name='Sport',
        ),
        migrations.AddField(
            model_name='attempt',
            name='climb',
            field=models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='SendItApp.Climb'),
        ),
    ]
