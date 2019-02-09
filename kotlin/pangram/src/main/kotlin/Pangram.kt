package Pangram

val alphabet = ('a'..'z');

fun isPangram(pangram: String): Boolean = alphabet.all { pangram.contains(it, ignoreCase = true) }