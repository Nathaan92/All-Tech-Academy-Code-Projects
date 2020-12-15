# Generated by Django 2.2.5 on 2020-09-10 03:46

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('SendItApp', '0014_auto_20200908_1817'),
    ]

    operations = [
        migrations.AlterField(
            model_name='attempt',
            name='light',
            field=models.CharField(choices=[('Shade', 'Shade'), ('Sun', 'Sun'), ('Night', 'Night')], default='', max_length=40, verbose_name='Lighting'),
        ),
        migrations.AlterField(
            model_name='attempt',
            name='notes',
            field=models.CharField(default='', max_length=255, null=True),
        ),
        migrations.AlterField(
            model_name='attempt',
            name='shoes',
            field=models.CharField(default='', max_length=40),
        ),
        migrations.AlterField(
            model_name='attempt',
            name='status',
            field=models.CharField(choices=[('Onsight', 'Onsight'), ('Redpoint', 'Redpoint'), ('Pinkpoint', 'Pinkpoint'), ('To Do', 'To Do'), ('Flash', 'Flash'), ('Flail', 'Flail'), ('Sent', 'Sent')], default='', max_length=40),
        ),
        migrations.AlterField(
            model_name='climb',
            name='grade',
            field=models.CharField(choices=[('5.7', '5.7'), ('5.8', '5.8'), ('5.9', '5.9'), ('5.10a', '5.10a'), ('5.10b', '5.10b'), ('5.10c', '5.10c'), ('5.10d', '5.10d'), ('5.11a', '5.11a'), ('5.11b', '5.11b'), ('5.11c', '5.11c'), ('5.11d', '5.11d'), ('5.12a', '5.12a'), ('5.12b', '5.12b'), ('5.12c', '5.12c'), ('5.12d', '5.12d'), ('5.13a', '5.13a'), ('5.13b', '5.13b'), ('5.13c', '5.13c'), ('5.13d', '5.13d'), ('5.14a', '5.14a'), ('5.14b', '5.14b'), ('5.14c', '5.14c'), ('5.14d', '5.14d'), ('5.15a', '5.15a'), ('5.15b', '5.15b'), ('5.15c', '5.15c'), ('5.15d', '5.15d'), ('V1', 'V1'), ('V2', 'V2'), ('V3', 'V3'), ('V4', 'V4'), ('V5', 'V5'), ('V6', 'V6'), ('V7', 'V7'), ('V8', 'V8'), ('V9', 'V9'), ('V10', 'V10'), ('V11', 'V11'), ('V12', 'V12'), ('V13', 'V13'), ('V14', 'V14'), ('V15', 'V15'), ('WI1', 'WI1'), ('WI1+', 'WI1+'), ('WI2', 'WI2'), ('WI2+', 'WI2+'), ('WI3', 'WI3'), ('WI3+', 'WI3+'), ('WI4', 'WI4'), ('WI4+', 'WI4+'), ('WI5', 'WI5'), ('WI5+', 'WI5+'), ('WI6', 'WI6'), ('WI6+', 'WI6+'), ('WI7', 'WI7'), ('WI7+', 'WI7+')], default='', max_length=20, verbose_name='Grade'),
        ),
        migrations.AlterField(
            model_name='climb',
            name='image',
            field=models.URLField(blank=True, default='', max_length=255, null=True, verbose_name='Image'),
        ),
        migrations.AlterField(
            model_name='climb',
            name='name',
            field=models.CharField(default='Name', max_length=40, verbose_name='Name'),
        ),
        migrations.AlterField(
            model_name='climb',
            name='pitches',
            field=models.PositiveIntegerField(default='1', verbose_name='Pitches'),
        ),
        migrations.AlterField(
            model_name='climb',
            name='rock',
            field=models.CharField(choices=[('Granite', 'Granite'), ('Limestone', 'Limestone'), ('Quartzite', 'Quartzite'), ('Sandstone', 'Sandstone'), ('Cobble', 'Cobble'), ('Gneiss', 'Gneiss'), ('Unknown', 'Unknown')], default='', max_length=40, verbose_name='Rock Type'),
        ),
        migrations.AlterField(
            model_name='climb',
            name='type',
            field=models.CharField(choices=[('Sport', 'Sport'), ('Boulder', 'Boulder'), ('Trad', 'Trad'), ('Alpine', 'Alpine'), ('Ice', 'Ice')], default='', max_length=30, verbose_name='Type'),
        ),
    ]