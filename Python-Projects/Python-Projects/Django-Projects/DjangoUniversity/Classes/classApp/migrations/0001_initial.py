# Generated by Django 3.1 on 2020-08-11 03:27

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='djangoClasses',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('Title', models.CharField(default='', max_length=60)),
                ('Course_Number', models.TextField(blank=True, default='', max_length=300)),
                ('Instructor_Name', models.CharField(default='', max_length=60)),
                ('Duration', models.DecimalField(decimal_places=2, default=0.0, max_digits=1000)),
            ],
        ),
    ]
