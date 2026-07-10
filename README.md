# InfiniteCharmsMod

Mod base para Hollow Knight Mobile.

## Qué hace
Hace que el juego lea `charmSlots` como 99, lo bastante alto para equipar todos los amuletos que ya tengas.

## Compilación
1. Abre el proyecto en Visual Studio.
2. Agrega referencias a:
   - `Assembly-CSharp.dll`
   - `UnityEngine.dll` o `UnityEngine.CoreModule.dll`
   - la DLL de la API de mods que use tu port
3. Compila como Class Library.
4. Copia el `.dll` final a:
   `Android/data/com.TeamCherry.HollowKnight/files/Mods`

## Nota
Si tu port usa otro nombre para la DLL de la API, cambia la referencia del proyecto.
