using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class xNyuDebugMenu : MonoBehaviour
{

	public xNyuDebugMenu()
	{
	}

	public void OnGUI()
	{
		if (xnyu_menu_enabled)
		{
			GUI.color = new Color(1f, 1f, 1f, 1f);
			GUI.Box(new Rect(0f, 0f, width, height), "");
			GUI.Box(new Rect(0f, 0f, width, height), "");
			GUI.Box(new Rect(0f, 0f, width, height), "");
			GUI.Box(new Rect(0f, 0f, width, height), "");
			GUI.Box(new Rect(0f, 0f, width, height), "");
			GUI.Box(new Rect(0f, 0f, width, height), "");
			GUI.color = new Color(1f, 1f, 1f, 1f);

			CameraController DrawCam = UnityEngine.Object.FindObjectOfType<CameraController>();
			GUI.Toggle(new Rect(DebugDrawX - 100f, DebugDrawY - 100f, 400f, 20f * scr_scale_h), xnyu_details_toggles[0], "World: " + Directory.GetCurrentDirectory(), font_purple);

			//Title and Version
			GUI.Toggle(new Rect(DebugDrawX - (90f * scr_scale_w), 150f * scr_scale_h, 400f, 30f), xnyu_details_toggles[0], "Sein Debugger by xNyu", font_title_red);
			GUI.Toggle(new Rect(DebugDrawX - (25f * scr_scale_w), 195f * scr_scale_h, 400f, 30f), xnyu_details_toggles[0], "Version 1.0", font_title_yellow);

			//Draw Details Options
			GUI.Toggle(new Rect(500f * scr_scale_w, DebugDrawY, 400f, 20f * scr_scale_h), xnyu_details_toggles[0], "Enable Details (Click to toggle)", xnyu_details_toggles[0] ? font_yellow : font_white);
			GUI.Toggle(new Rect(500f * scr_scale_w, DebugDrawY + 20f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[1], "Show Sein Data", xnyu_details_toggles[0] ? (xnyu_details_toggles[1] ? font_green : font_red) : font_gray);
			GUI.Toggle(new Rect(500f * scr_scale_w, DebugDrawY + 40f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[2], "Show Sein Booleans", xnyu_details_toggles[0] ? (xnyu_details_toggles[2] ? font_green : font_red) : font_gray);
			GUI.Toggle(new Rect(500f * scr_scale_w, DebugDrawY + 60f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[3], "Show Platform Data", xnyu_details_toggles[0] ? (xnyu_details_toggles[3] ? font_green : font_red) : font_gray);
			GUI.Toggle(new Rect(500f * scr_scale_w, DebugDrawY + 80f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[4], "Show Platform Booleans", xnyu_details_toggles[0] ? (xnyu_details_toggles[4] ? font_green : font_red) : font_gray);
			GUI.Toggle(new Rect(500f * scr_scale_w, DebugDrawY + 100f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[5], "Show World Data", xnyu_details_toggles[0] ? (xnyu_details_toggles[5] ? font_green : font_red) : font_gray);
			GUI.Toggle(new Rect(500f * scr_scale_w, DebugDrawY + 120f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[6], "Show World Booleans", xnyu_details_toggles[0] ? (xnyu_details_toggles[6] ? font_green : font_red) : font_gray);
			GUI.Toggle(new Rect(500f * scr_scale_w, DebugDrawY + 140f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[6], "Show Camera Data", xnyu_details_toggles[0] ? (xnyu_details_toggles[7] ? font_green : font_red) : font_gray);
			GUI.Toggle(new Rect(500f * scr_scale_w, DebugDrawY + 160f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[6], "Show Soulflame Data", xnyu_details_toggles[0] ? (xnyu_details_toggles[8] ? font_green : font_red) : font_gray);

			//Draw Debug Options
			GUI.Toggle(new Rect(80f * scr_scale_w, DebugDrawY, 400f, 20f * scr_scale_h), xnyu_details_toggles[0], "Enable Debugtext (Click to toggle)", xnyu_debug_toggles[0] ? font_yellow : font_white);
			GUI.Toggle(new Rect(80f * scr_scale_w, DebugDrawY + 20f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[1], "Door Debugtext", xnyu_debug_toggles[0] ? (xnyu_debug_toggles[1] ? font_green : font_red) : font_gray);
			GUI.Toggle(new Rect(80f * scr_scale_w, DebugDrawY + 40f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[2], "Teleporter Debugtext", xnyu_debug_toggles[0] ? (xnyu_debug_toggles[2] ? font_green : font_red) : font_gray);
			GUI.Toggle(new Rect(80f * scr_scale_w, DebugDrawY + 60f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[4], "Enemy Debugtext", xnyu_debug_toggles[0] ? (xnyu_debug_toggles[4] ? font_green : font_red) : font_gray);
			GUI.Toggle(new Rect(80f * scr_scale_w, DebugDrawY + 80f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[4], "Collectable Debugtext", xnyu_debug_toggles[0] ? (xnyu_debug_toggles[5] ? font_green : font_red) : font_gray);

			//Keybindings
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 0f* scr_scale_h, 400f * scr_scale_w, 20f * scr_scale_h), "Keybindings (Click to toggle)",  key_binding_toggle ? font_yellow : font_white);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 20f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "NUM_1: " + key_settings[0], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 40f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "NUM_2: " + key_settings[1], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 60f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "NUM_3: " + key_settings[2], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 80f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "NUM_4: " + key_settings[3], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 100f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "NUM_5: " + key_settings[4], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 120f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "NUM_6: " + key_settings[5], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 140f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "NUM_7: " + key_settings[6], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 160f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "NUM_8: " + key_settings[7], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 180f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "NUM_9: " + key_settings[8], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 200f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "F1:    " + key_settings[9], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 220f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "F2:    " + key_settings[10], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 240f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "F3:    " + key_settings[11], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 260f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "F4:    " + key_settings[12], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 280f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "F5:    " + key_settings[13], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 300f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "F6:    " + key_settings[14], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 320f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "F7:    " + key_settings[15], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 340f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "F8:    " + key_settings[16], key_binding_toggle ? font_purple : font_gray);
			GUI.Label(new Rect(920f * scr_scale_w, DebugDrawY + 360f* scr_scale_h, 200f * scr_scale_w, 20f * scr_scale_h), "Reload Settings from file", key_binding_toggle ? font_blue : font_gray);

			if(xnyu_menu_key_select_enabled){
				//Hotkey Functions
				GUI.color = new Color(1f, 1f, 1f, 1f);
				GUI.Box(new Rect(0f, 0f, width, height), "");
				GUI.Box(new Rect(0f, 0f, width, height), "");
				GUI.Box(new Rect(0f, 0f, width, height), "");
				GUI.Box(new Rect(0f, 0f, width, height), "");
				GUI.Box(new Rect(0f, 0f, width, height), "");
				GUI.Box(new Rect(0f, 0f, width, height), "");
				GUI.color = new Color(1f, 1f, 1f, 1f);

				int key_row = 0;
				int key_line = 0;
				for(int i = 0; i < Key_functions_list.Count; i++){
					List<string> k_tmp_list = Key_functions_list[i];
					GUI.Label(new Rect((80f + key_row * 420f) * scr_scale_w, (80f + 0f + key_line * 500f) * scr_scale_h, 400f * scr_scale_w, 20f * scr_scale_h), k_tmp_list[0], font_yellow);
					for(int k = 1; k < k_tmp_list.Count; k++){
						GUI.Label(new Rect((80f + key_row * 420f) * scr_scale_w, (80f + 20f * k + key_line * 500f) * scr_scale_h, 400f * scr_scale_w, 20f * scr_scale_h), k_tmp_list[k], font_yellow);
					}
					key_row++;
					if(key_row > 3){
						key_line++;
						key_row = 0;
					}
				}

			}

		}else{
			//Drawing details is activated
			if(xnyu_details_toggles[0]){

				if(xnyu_details.Count > 0){
					//Draw scaled box background
					GUI.color = new Color(1f, 1f, 1f, 0.85f);
					GUI.Box(new Rect(0f, 0f, 80f + ((250f * scr_scale_w)*details_box_width), 80f + ((20f * scr_scale_h) * details_box_height)), "");
					GUI.Box(new Rect(0f, 0f, 80f + ((250f * scr_scale_w)*details_box_width), 80f + ((20f * scr_scale_h) * details_box_height)), "");
					GUI.Box(new Rect(0f, 0f, 80f + ((250f * scr_scale_w)*details_box_width), 80f + ((20f * scr_scale_h) * details_box_height)), "");
					GUI.color = new Color(1f, 1f, 1f, 1f);

					//Draw details
					float row = 0f;
					float line = 0f;
					for(int i = 0; i < xnyu_details.Count; i++){
						if(i > 0 && i % 22 == 0){
							row = row + 1f;
							line = 0;
						}
						string color_tenery = xnyu_details[i];
						try{GUI.Label(new Rect(20f + ((250f * scr_scale_w) * row), 20f + ((20f * scr_scale_h) * line), 200f * scr_scale_w, 20f * scr_scale_h), xnyu_details[i], (color_tenery[0] == '-' && color_tenery[color_tenery.Length - 1] == '-') ? font_blue : font_white);}catch{}
						line++;
					}

				}

			}

			//Enemy Debug Data
			if(GlobalEnemyDebug){
				foreach(xNyuDebugEnemyData enemy in GlobalEnemyList){
					if(enemy.DrawPosition.x > 0 && enemy.DrawPosition.x < width && enemy.DrawPosition.y > 0 && enemy.DrawPosition.y < height){
						Vector3 DrawCoords = WorldCameraDraw.WorldToScreenPoint(enemy.Positiony);
						GUI.color = new Color(1f, 1f, 1f, 1f);
						GUI.Box(new Rect(DrawCoords.x, Screen.height - DrawCoords.y, 150f * scr_scale_w, 80f * scr_scale_h), "");
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 5f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), enemy.CurrentPosition, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 15f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), enemy.StartPosition, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 25f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), enemy.Damage, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 35f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), enemy.DamagePlayerOnly, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 45f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), enemy.FrustumOptimized, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 55f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), enemy.InsideFrustum, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 65f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), enemy.IsInWater, font_dbg_blue);
					}
				}
			}

			//Door Debug Data
			if(GlobalDoorDebug){
				foreach(xNyuDebugDoorData door in GlobalDoorList){
					if(door.DrawPosition.x > 0 && door.DrawPosition.x < width && door.DrawPosition.y > 0 && door.DrawPosition.y < height){
						Vector3 DrawCoords = WorldCameraDraw.WorldToScreenPoint(door.Positiony);
						GUI.color = new Color(1f, 1f, 1f, 1f);
						GUI.Box(new Rect(DrawCoords.x, Screen.height - DrawCoords.y, 150f * scr_scale_w, 70f * scr_scale_h), "");
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 5f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), door.Position, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 15f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), door.val1, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 25f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), door.val2, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 35f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), door.val3, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 45f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), door.val4, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 55f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), door.val5, font_dbg_blue);
					}
				}
			}

			//Teleporter Debug Data
			if(GlobalTeleporterDebug){
				foreach(xNyuDebugTeleporterData teleporter in GlobalTeleporterList){
					if(teleporter.DrawPosition.x > 0 && teleporter.DrawPosition.x < width && teleporter.DrawPosition.y > 0 && teleporter.DrawPosition.y < height){
						Vector3 DrawCoords = WorldCameraDraw.WorldToScreenPoint(teleporter.Positiony);
						GUI.color = new Color(1f, 1f, 1f, 1f);
						GUI.Box(new Rect(DrawCoords.x, Screen.height - DrawCoords.y, 210f * scr_scale_w, 60f * scr_scale_h), "");
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 5f * scr_scale_h, 150f * scr_scale_w, 10f * scr_scale_h), teleporter.Position, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 15f * scr_scale_h, 150f * scr_scale_w, 10f * scr_scale_h), teleporter.val1, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 25f * scr_scale_h, 150f * scr_scale_w, 10f * scr_scale_h), teleporter.val2, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 35f * scr_scale_h, 150f * scr_scale_w, 10f * scr_scale_h), teleporter.val3, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 45f * scr_scale_h, 150f * scr_scale_w, 10f * scr_scale_h), teleporter.val4, font_dbg_blue);
					}
				}
			}

			//Collectable Debug Data
			if(GlobalCollectablesDebug){
				foreach(xNyuDebugCollectableData collectable in GlobalCollectableList){
					if(collectable.DrawPosition.x > 0 && collectable.DrawPosition.x < width && collectable.DrawPosition.y > 0 && collectable.DrawPosition.y < height){
						Vector3 DrawCoords = WorldCameraDraw.WorldToScreenPoint(collectable.Positiony);
						GUI.color = new Color(1f, 1f, 1f, 1f);
						GUI.Box(new Rect(DrawCoords.x, Screen.height - DrawCoords.y, 150f * scr_scale_w, 70f * scr_scale_h), "");
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 5f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), collectable.Position, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 15f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), collectable.val1, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 25f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), collectable.val2, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 35f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), collectable.val3, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 45f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), collectable.val4, font_dbg_blue);
						GUI.Label(new Rect(DrawCoords.x + 5f, Screen.height - DrawCoords.y + 55f * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), collectable.val5, font_dbg_blue);
					}
				}
			}


		}
	}

	public void Update()
	{
		//Values we need to keep actualized
		width = (float)Screen.width;
		height = (float)Screen.height;
		scr_scale_w = width / fixed_size_w;
		scr_scale_h = height / fixed_size_h;
		f_size = (int)(13f * scr_scale_w);
		f_dbg_size = (int)(9f * scr_scale_w);

		DebugDrawX = width/2 - 100f;
		DebugDrawY = height/2 - 60f;

		font_white.fontSize = f_size;
		font_red.fontSize = f_size;
		font_green.fontSize = f_size;
		font_gray.fontSize = f_size;
		font_yellow.fontSize = f_size;
		font_blue.fontSize = f_size;
		font_purple.fontSize = f_size;
		font_dbg_blue.fontSize = f_dbg_size;

		//Click the checkboxes
		if(xnyu_menu_enabled){
			Vector3 mouse = Input.mousePosition;
			mouse.y = height - mouse.y;
			if(Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2)){

				//Normal Select
				if(!xnyu_menu_key_select_enabled){
					//Details
					if(mouse.x > 500f * scr_scale_w && mouse.x < 500f * scr_scale_w + 400f * scr_scale_w && mouse.y < DebugDrawY + 20f * scr_scale_h && mouse.y > DebugDrawY) xnyu_details_toggles[0] = !xnyu_details_toggles[0];
					if(xnyu_details_toggles[0] && mouse.x > 500f * scr_scale_w && mouse.x < 500f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 40f * scr_scale_h && mouse.y > DebugDrawY + 20f * scr_scale_h) xnyu_details_toggles[1] = !xnyu_details_toggles[1];
					if(xnyu_details_toggles[0] && mouse.x > 500f * scr_scale_w && mouse.x < 500f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 60f * scr_scale_h && mouse.y > DebugDrawY + 40f * scr_scale_h) xnyu_details_toggles[2] = !xnyu_details_toggles[2];
					if(xnyu_details_toggles[0] && mouse.x > 500f * scr_scale_w && mouse.x < 500f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 80f * scr_scale_h && mouse.y > DebugDrawY + 60f * scr_scale_h) xnyu_details_toggles[3] = !xnyu_details_toggles[3];
					if(xnyu_details_toggles[0] && mouse.x > 500f * scr_scale_w && mouse.x < 500f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 100f * scr_scale_h && mouse.y > DebugDrawY + 80f * scr_scale_h) xnyu_details_toggles[4] = !xnyu_details_toggles[4];
					if(xnyu_details_toggles[0] && mouse.x > 500f * scr_scale_w && mouse.x < 500f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 120f * scr_scale_h && mouse.y > DebugDrawY + 100f * scr_scale_h) xnyu_details_toggles[5] = !xnyu_details_toggles[5];
					if(xnyu_details_toggles[0] && mouse.x > 500f * scr_scale_w && mouse.x < 500f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 140f * scr_scale_h && mouse.y > DebugDrawY + 120f * scr_scale_h) xnyu_details_toggles[6] = !xnyu_details_toggles[6];
					if(xnyu_details_toggles[0] && mouse.x > 500f * scr_scale_w && mouse.x < 500f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 160f * scr_scale_h && mouse.y > DebugDrawY + 140f * scr_scale_h) xnyu_details_toggles[7] = !xnyu_details_toggles[7];
					if(xnyu_details_toggles[0] && mouse.x > 500f * scr_scale_w && mouse.x < 500f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 180f * scr_scale_h && mouse.y > DebugDrawY + 160f * scr_scale_h) xnyu_details_toggles[8] = !xnyu_details_toggles[8];

					//Debugtext
					if(mouse.x > 80f * scr_scale_w && mouse.x < 80f * scr_scale_w + 400f * scr_scale_w && mouse.y < DebugDrawY + 20f * scr_scale_h && mouse.y > DebugDrawY) xnyu_debug_toggles[0] = !xnyu_debug_toggles[0];
					if(xnyu_debug_toggles[0] && mouse.x > 80f * scr_scale_w && mouse.x < 80f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 40f * scr_scale_h && mouse.y > DebugDrawY + 20f * scr_scale_h) {xnyu_debug_toggles[1] = !xnyu_debug_toggles[1]; GlobalDoorDebugFirstInit = true;}
					if(xnyu_debug_toggles[0] && mouse.x > 80f * scr_scale_w && mouse.x < 80f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 60f * scr_scale_h && mouse.y > DebugDrawY + 40f * scr_scale_h) {xnyu_debug_toggles[2] = !xnyu_debug_toggles[2]; GlobalTeleporterDebugFirstInit = true;}
					if(xnyu_debug_toggles[0] && mouse.x > 80f * scr_scale_w && mouse.x < 80f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 80f * scr_scale_h && mouse.y > DebugDrawY + 60f * scr_scale_h) {xnyu_debug_toggles[4] = !xnyu_debug_toggles[4]; GlobalEnemyDebugFirstInit = true; GlobalEnemyDebugIndexCounter = 0;}
					if(xnyu_debug_toggles[0] && mouse.x > 80f * scr_scale_w && mouse.x < 80f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 100f * scr_scale_h && mouse.y > DebugDrawY + 80f * scr_scale_h) {xnyu_debug_toggles[5] = !xnyu_debug_toggles[5]; GlobalCollectablesDebugFirstInit = true; GlobalCollectableDebugIndexCounter = 0;}

					//Keybindings
					if(mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 400f * scr_scale_w && mouse.y < DebugDrawY + 20f * scr_scale_h && mouse.y > DebugDrawY) key_binding_toggle = !key_binding_toggle;
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 40f * scr_scale_h && mouse.y > DebugDrawY + 20f * scr_scale_h) {key_binding_index = 0; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 60f * scr_scale_h && mouse.y > DebugDrawY + 40f * scr_scale_h) {key_binding_index = 1; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 80f * scr_scale_h && mouse.y > DebugDrawY + 60f * scr_scale_h) {key_binding_index = 2; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 100f * scr_scale_h && mouse.y > DebugDrawY + 80f * scr_scale_h) {key_binding_index = 3; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 120f * scr_scale_h && mouse.y > DebugDrawY + 100f * scr_scale_h) {key_binding_index = 4; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 140f * scr_scale_h && mouse.y > DebugDrawY + 120f * scr_scale_h) {key_binding_index = 5; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 160f * scr_scale_h && mouse.y > DebugDrawY + 140f * scr_scale_h) {key_binding_index = 6; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 180f * scr_scale_h && mouse.y > DebugDrawY + 160f * scr_scale_h) {key_binding_index = 7; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 200f * scr_scale_h && mouse.y > DebugDrawY + 180f * scr_scale_h) {key_binding_index = 8; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 220f * scr_scale_h && mouse.y > DebugDrawY + 200f * scr_scale_h) {key_binding_index = 9; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 240f * scr_scale_h && mouse.y > DebugDrawY + 220f * scr_scale_h) {key_binding_index = 10; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 260f * scr_scale_h && mouse.y > DebugDrawY + 240f * scr_scale_h) {key_binding_index = 11; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 280f * scr_scale_h && mouse.y > DebugDrawY + 260f * scr_scale_h) {key_binding_index = 12; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 300f * scr_scale_h && mouse.y > DebugDrawY + 280f * scr_scale_h) {key_binding_index = 13; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 320f * scr_scale_h && mouse.y > DebugDrawY + 300f * scr_scale_h) {key_binding_index = 14; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 340f * scr_scale_h && mouse.y > DebugDrawY + 320f * scr_scale_h) {key_binding_index = 15; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 360f * scr_scale_h && mouse.y > DebugDrawY + 340f * scr_scale_h) {key_binding_index = 16; xnyu_menu_key_select_enabled = true;}
					if(key_binding_toggle && mouse.x > 920f * scr_scale_w && mouse.x < 920f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 380f * scr_scale_h && mouse.y > DebugDrawY + 360f * scr_scale_h) {string[] key_settings_lines = File.ReadAllLines(settings_file);for(int i = 0; i < key_settings_lines.Length; i++){key_settings[i] = key_settings_lines[i].Split(':')[1];}}

				}else{
					//Hotkey Select
					int key_row = 0;
					int key_line = 0;
					bool break_this = false;
					for(int i = 0; i < Key_functions_list.Count; i++){
						List<string> k_tmp_list = Key_functions_list[i];
						for(int k = 1; k < k_tmp_list.Count; k++){
							if(mouse.x > (80f + key_row * 420f) * scr_scale_w && mouse.x < (80f + key_row * 420f + 400f) * scr_scale_w && mouse.y < (80f + 20f * k + key_line * 500f + 20f) * scr_scale_h && mouse.y > (80f + 20f * k + key_line * 500f) * scr_scale_h){
								//New Key Fucntion
								key_settings[key_binding_index] = k_tmp_list[k];

								//Save Key Settings
								string[] tmps_setting = new string[17];
								tmps_setting[0] = "NUM_1:" + key_settings[0];
								tmps_setting[1] = "NUM_2:" + key_settings[2];
								tmps_setting[2] = "NUM_3:" + key_settings[2];
								tmps_setting[3] = "NUM_4:" + key_settings[3];
								tmps_setting[4] = "NUM_5:" + key_settings[4];
								tmps_setting[5] = "NUM_6:" + key_settings[5];
								tmps_setting[6] = "NUM_7:" + key_settings[6];
								tmps_setting[7] = "NUM_8:" + key_settings[7];
								tmps_setting[8] = "NUM_9:" + key_settings[8];
								tmps_setting[9] = "F1:" + key_settings[9];
								tmps_setting[10] = "F2:" + key_settings[10];
								tmps_setting[11] = "F3:" + key_settings[11];
								tmps_setting[12] = "F4:" + key_settings[12];
								tmps_setting[13] = "F5:" + key_settings[13];
								tmps_setting[14] = "F6:" + key_settings[14];
								tmps_setting[15] = "F7:" + key_settings[15];
								tmps_setting[16] = "F8:" + key_settings[16];
								File.WriteAllLines(settings_file, tmps_setting);

								//Disable Key Select Menu
								xnyu_menu_key_select_enabled = false;
								break;
							}
						}
						if(break_this) break;
						key_row++;
						if(key_row > 3){
							key_line++;
							key_row = 0;
						}
					}



				}

			}
		}

		//Set Debugtext Trigger
		if(xnyu_debug_toggles[0]){
			GlobalDoorDebug = xnyu_debug_toggles[1];
			GlobalTeleporterDebug = xnyu_debug_toggles[2];
			GlobalTreeDebug = xnyu_debug_toggles[3];
			GlobalEnemyDebug = xnyu_debug_toggles[4];
			GlobalCollectablesDebug = xnyu_debug_toggles[5];
		}else{
			GlobalDoorDebug = false;
			GlobalTeleporterDebug = false;
			GlobalTreeDebug = false;
			GlobalEnemyDebug = false;
			GlobalCollectablesDebug = false;
		}

		//Open Debug Menu
		if (Input.GetKeyUp(KeyCode.Keypad0) || Input.GetKeyUp(KeyCode.F10))
		{
			if(xnyu_menu_enabled){
				//Resume Gameplay and close menu
				DebugMenuB.ResumeGameplay();
				xnyu_menu_enabled = false;
			}else{
				//Pause Gameplay and open menu
				DebugMenuB.SuspendGameplay();
				xnyu_menu_enabled = true;
				xnyu_menu_key_select_enabled = false;
			}
		}

		//Escape Key for comfort
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			if(xnyu_menu_key_select_enabled){

				xnyu_menu_key_select_enabled = false;
			}else{
				if(xnyu_menu_enabled){
					//Resume Gameplay and close menu
					DebugMenuB.ResumeGameplay();
					xnyu_menu_enabled = false;
				}
			}
		}

		if (Input.GetKey(KeyCode.Keypad2))
		{
			UnityEngine.Object.FindObjectOfType<SeinCharacter>().transform.Rotate(0f, 20f, 0f);
		}
		


		//Keybindings Call Functions
		if(!xnyu_menu_enabled){
		if(Input.GetKey(KeyCode.Keypad1) && key_can_press[0]){
			key_can_press[0] = HotkeyToFunc(key_settings[0]);
		}else if(Input.GetKey(KeyCode.Keypad2) && key_can_press[1]){
			key_can_press[1] = HotkeyToFunc(key_settings[1]);
		}else if(Input.GetKey(KeyCode.Keypad3) && key_can_press[2]){
			key_can_press[2] = HotkeyToFunc(key_settings[2]);
		}else if(Input.GetKey(KeyCode.Keypad4) && key_can_press[3]){
			key_can_press[3] = HotkeyToFunc(key_settings[3]);
		}else if(Input.GetKey(KeyCode.Keypad5) && key_can_press[4]){
			key_can_press[4] = HotkeyToFunc(key_settings[4]);
		}else if(Input.GetKey(KeyCode.Keypad6) && key_can_press[5]){
			key_can_press[5] = HotkeyToFunc(key_settings[5]);
		}else if(Input.GetKey(KeyCode.Keypad7) && key_can_press[6]){
			key_can_press[6] = HotkeyToFunc(key_settings[6]);
		}else if(Input.GetKey(KeyCode.Keypad8) && key_can_press[7]){
			key_can_press[7] = HotkeyToFunc(key_settings[7]);
		}else if(Input.GetKey(KeyCode.Keypad9) && key_can_press[8]){
			key_can_press[8] = HotkeyToFunc(key_settings[8]);
		}else if(Input.GetKey(KeyCode.F1) && key_can_press[9]){
			key_can_press[9] = HotkeyToFunc(key_settings[9]);
		}else if(Input.GetKey(KeyCode.F2) && key_can_press[10]){
			key_can_press[10] = HotkeyToFunc(key_settings[10]);
		}else if(Input.GetKey(KeyCode.F3) && key_can_press[11]){
			key_can_press[11] = HotkeyToFunc(key_settings[11]);
		}else if(Input.GetKey(KeyCode.F4) && key_can_press[12]){
			key_can_press[12] = HotkeyToFunc(key_settings[12]);
		}else if(Input.GetKey(KeyCode.F5) && key_can_press[13]){
			key_can_press[13] = HotkeyToFunc(key_settings[13]);
		}else if(Input.GetKey(KeyCode.F6) && key_can_press[14]){
			key_can_press[14] = HotkeyToFunc(key_settings[14]);
		}else if(Input.GetKey(KeyCode.F7) && key_can_press[15]){
			key_can_press[15] = HotkeyToFunc(key_settings[15]);
		}else if(Input.GetKey(KeyCode.F8) && key_can_press[16]){
			key_can_press[16] = HotkeyToFunc(key_settings[16]);
		}

		//Keybindings Release Detection
		if(Input.GetKeyUp(KeyCode.Keypad1)){
			key_can_press[0] = true;
		}
		if(Input.GetKeyUp(KeyCode.Keypad2)){
			key_can_press[1] = true;
		}
		if(Input.GetKeyUp(KeyCode.Keypad3)){
			key_can_press[2] = true;
		}
		if(Input.GetKeyUp(KeyCode.Keypad4)){
			key_can_press[3] = true;
		}
		if(Input.GetKeyUp(KeyCode.Keypad5)){
			key_can_press[4] = true;
		}
		if(Input.GetKeyUp(KeyCode.Keypad6)){
			key_can_press[5] = true;
		}
		if(Input.GetKeyUp(KeyCode.Keypad7)){
			key_can_press[6] = true;
		}
		if(Input.GetKeyUp(KeyCode.Keypad8)){
			key_can_press[7] = true;
		}
		if(Input.GetKeyUp(KeyCode.Keypad9)){
			key_can_press[8] = true;
		}
		if(Input.GetKeyUp(KeyCode.F1)){
			key_can_press[9] = true;
		}
		if(Input.GetKeyUp(KeyCode.F2)){
			key_can_press[10] = true;
		}
		if(Input.GetKeyUp(KeyCode.F3)){
			key_can_press[11] = true;
		}
		if(Input.GetKeyUp(KeyCode.F4)){
			key_can_press[12] = true;
		}
		if(Input.GetKeyUp(KeyCode.F5)){
			key_can_press[13] = true;
		}
		if(Input.GetKeyUp(KeyCode.F6)){
			key_can_press[14] = true;
		}
		if(Input.GetKeyUp(KeyCode.F7)){
			key_can_press[15] = true;
		}
		if(Input.GetKeyUp(KeyCode.F8)){
			key_can_press[16] = true;
		}
		}


		//Prepare Details display
		if(xnyu_details_toggles[0] && !xnyu_menu_enabled && DetailsSlowDown == 0){

			if(xnyu_details.Count > 0) xnyu_details.Clear();

			//Get isntances to read from
			SeinCharacter ori_object = UnityEngine.Object.FindObjectOfType<SeinCharacter>();
			SeinController ori_controller = UnityEngine.Object.FindObjectOfType<SeinController>();
			CameraController world_cam = UnityEngine.Object.FindObjectOfType<CameraController>();
			TeleporterController teleporter_controller = FindObjectOfType<TeleporterController>();

			if(xnyu_details_toggles[1]){
				//Sein Data
				xnyu_details.Add("-Sein Data-");
				xnyu_details.Add("Position: " + ((ori_object != null) ? ori_object.transform.position.ToString() : "N/A"));
				xnyu_details.Add("Speed: " + ((ori_object != null) ? ori_object.Speed.ToString() : "N/A"));
				xnyu_details.Add("Physics Speed: " + ((ori_object != null) ? ori_object.PhysicsSpeed.ToString() : "N/A"));
				xnyu_details.Add("Hurt Drop Pickup Speed: " + ((ori_object != null) ? ori_object.Mortality.DamageReciever.HurtDropPickupSpeed.ToString() : "N/A"));
				xnyu_details.Add("Energy Current/Max: " + ((ori_object != null) ? (ori_object.Energy.Current.ToString() + "/" + ori_object.Energy.Max.ToString()) : "N/A"));
				xnyu_details.Add("Health Current/Max: " + ((ori_object != null) ? (ori_object.Mortality.Health.Amount.ToString() + "/" + ori_object.Mortality.Health.MaxHealth.ToString()) : "N/A"));
				xnyu_details.Add("Spawn Duration: " + ((ori_object != null) ? ori_object.Mortality.DamageReciever.SpawnDuration.ToString() : "N/A"));
			}

			if(xnyu_details_toggles[2]){
				//Sein Booleans Data
				xnyu_details.Add("-Sein Booleans-");
				xnyu_details.Add("Sein Enabled: " + ((ori_object != null) ? ori_object.enabled.ToString() : "N/A"));
				xnyu_details.Add("Sein Active: " + ((ori_object != null) ? ori_object.Active.ToString() : "N/A"));
				xnyu_details.Add("Has Keystones: " + ((ori_object != null) ? ori_object.Inventory.HasKeystones.ToString() : "N/A"));
				xnyu_details.Add("Has Mapstones: " + ((ori_object != null) ? ori_object.Inventory.HasMapstones.ToString() : "N/A"));
				xnyu_details.Add("Face Left: " + ((ori_object != null) ? ori_object.FaceLeft.ToString() : "N/A"));
				xnyu_details.Add("Can Move: " + ((ori_controller != null) ? ori_controller.CanMove.ToString() : "N/A"));
				xnyu_details.Add("Input Locked: " + ((ori_controller != null) ? ori_controller.InputLocked.ToString() : "N/A"));
				xnyu_details.Add("Is On Ground: " + ((ori_object != null) ? ori_object.IsOnGround.ToString() : "N/A"));
				xnyu_details.Add("Is Immortal: " + ((ori_object != null) ? ori_object.Mortality.DamageReciever.IsImmortal.ToString() : "N/A"));
				xnyu_details.Add("Is Aiming Grenade: " + ((ori_controller != null) ? ori_controller.IsAimingGrenade.ToString() : "N/A"));
				xnyu_details.Add("Is Bashing: " + ((ori_controller != null) ? ori_controller.IsBashing.ToString() : "N/A"));
				xnyu_details.Add("Is Carrying: " + ((ori_controller != null) ? ori_controller.IsCarrying.ToString() : "N/A"));
				xnyu_details.Add("Is Charging: " + ((ori_controller != null) ? ori_controller.IsCharging.ToString() : "N/A"));
				xnyu_details.Add("Is Charging Jump: " + ((ori_controller != null) ? ori_controller.IsChargingJump.ToString() : "N/A"));
				xnyu_details.Add("Is Crouching: " + ((ori_controller != null) ? ori_controller.IsCrouching.ToString() : "N/A"));
				xnyu_details.Add("Is Dashing: " + ((ori_controller != null) ? ori_controller.IsDashing.ToString() : "N/A"));
				xnyu_details.Add("Is Gliding: " + ((ori_controller != null) ? ori_controller.IsGliding.ToString() : "N/A"));
				xnyu_details.Add("Is Grabbing Lever: " + ((ori_controller != null) ? ori_controller.IsGrabbingLever.ToString() : "N/A"));
				xnyu_details.Add("Is Grabbing Wall: " + ((ori_controller != null) ? ori_controller.IsGrabbingWall.ToString() : "N/A"));
				xnyu_details.Add("Is Inside Soulflame: " + ((ori_controller != null) ? ori_controller.IsInsideSoulFlame.ToString() : "N/A"));
				xnyu_details.Add("Is Push/Pulling: " + ((ori_controller != null) ? ori_controller.IsPushPulling.ToString() : "N/A"));
				xnyu_details.Add("Is Suspended: " + ((ori_controller != null) ? ori_controller.IsSuspended.ToString() : "N/A"));
				xnyu_details.Add("Is Swimming: " + ((ori_controller != null) ? ori_controller.IsSwimming.ToString() : "N/A"));
			}

			if(xnyu_details_toggles[3]){
				//Platform Data
				xnyu_details.Add("-Platform Data-");
				xnyu_details.Add("Friction Speed Factor: " + ((ori_object != null) ? ori_object.PlatformBehaviour.ApplyFrictionToSpeed.SpeedFactor.ToString() : "N/A"));
				xnyu_details.Add("Friction Slow Down: " + ((ori_object != null) ? ori_object.PlatformBehaviour.ApplyFrictionToSpeed.SpeedToSlowDown.ToString() : "N/A"));
				xnyu_details.Add("Ceiling Surface Type: " + ((ori_object != null) ? ori_object.PlatformBehaviour.CeilingSurfaceMaterialType.ToString() : "N/A"));
				xnyu_details.Add("Additional X Speed: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.AdditionalXSpeed.ToString() : "N/A"));
				xnyu_details.Add("Capsule Angle: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.CapsuleAngle.ToString() : "N/A"));
				xnyu_details.Add("Ceiling Angle: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.CeilingAngle.ToString() : "N/A"));
				xnyu_details.Add("Ceiling Binormal: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.CeilingBinormal.ToString() : "N/A"));
				xnyu_details.Add("Ceiling Normal: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.CeilingNormal.ToString() : "N/A"));
				xnyu_details.Add("Gravity Angle: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.GravityAngle.ToString() : "N/A"));
				xnyu_details.Add("Gravity Direction: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.GravityDirection.ToString() : "N/A"));
				xnyu_details.Add("Gravity Biormal: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.GravityBinormal.ToString() : "N/A"));
				xnyu_details.Add("Ground Angle: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.GroundAngle.ToString() : "N/A"));
				xnyu_details.Add("Ground Binormal: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.GroundBinormal.ToString() : "N/A"));
				xnyu_details.Add("Ground Normal: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.GroundNormal.ToString() : "N/A"));
				xnyu_details.Add("Keep Surface Direction: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.KeepOnSurfaceDirection.ToString() : "N/A"));
				xnyu_details.Add("Platform Position: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.Position.ToString() : "N/A"));
				xnyu_details.Add("Wall Left Angle: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.WallLeftAngle.ToString() : "N/A"));
				xnyu_details.Add("Wall Left Binormal: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.WallLeftBinormal.ToString() : "N/A"));
				xnyu_details.Add("Wall Left Normal: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.WallLeftNormal.ToString() : "N/A"));
				xnyu_details.Add("Wall Right Angle: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.WallRightAngle.ToString() : "N/A"));
				xnyu_details.Add("Wall Right Binormal: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.WallRightBinormal.ToString() : "N/A"));
				xnyu_details.Add("Wall Right Normal: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.WallRightNormal.ToString() : "N/A"));
				xnyu_details.Add("Worldspeed: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.WorldSpeed.ToString() : "N/A"));
			}

			if(xnyu_details_toggles[4]){
				//Platform Booleans
				xnyu_details.Add("-Platform Booleans-");
				xnyu_details.Add("Air No Deceleration: " + ((ori_object != null) ? ori_object.PlatformBehaviour.AirNoDeceleration.NoDeceleration.ToString() : "N/A"));
				xnyu_details.Add("Is On Ceiling: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.IsOnCeiling.ToString() : "N/A"));
				xnyu_details.Add("Is On Wall: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.IsOnWall.ToString() : "N/A"));
				xnyu_details.Add("Was On Wall: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.WasOnWall.ToString() : "N/A"));
				xnyu_details.Add("Ceiling Rayhit: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.CeilingRayHit.ToString() : "N/A"));
				xnyu_details.Add("Falling: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.Falling.ToString() : "N/A"));
				xnyu_details.Add("Jumping: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.Jumping.ToString() : "N/A"));
				xnyu_details.Add("Feet Against Wall: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.FeetAgainstWall.ToString() : "N/A"));
				xnyu_details.Add("Head Against Wall: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.HeadAgainstWall.ToString() : "N/A"));
				xnyu_details.Add("Force Keep in Air: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.ForceKeepInAir.ToString() : "N/A"));
				xnyu_details.Add("Ground Ray Hit: " + ((ori_object != null) ? ori_object.PlatformBehaviour.PlatformMovement.GroundRayHit.ToString() : "N/A"));
			}

			if(xnyu_details_toggles[5]){
				//World Data
				xnyu_details.Add("-World Data-");
				
				if(teleporter_controller != null){
					for(int i = 0; i < teleporter_controller.Teleporters.Count; i++){
						xnyu_details.Add("Teleporter [" + i.ToString() + "]: " + teleporter_controller.Teleporters[i].Name.name);
					}
				}
			}

			if(xnyu_details_toggles[7]){
				//Soulflame Data
				xnyu_details.Add("-Camera Data-");
				xnyu_details.Add("Camera Position: " + ((world_cam != null) ? world_cam.Camera.transform.position.ToString() : "N/A"));
				xnyu_details.Add("Aspect: " + ((world_cam != null) ? world_cam.Camera.aspect.ToString() : "N/A"));
				xnyu_details.Add("Command Buffer Count: " + ((world_cam != null) ? world_cam.Camera.commandBufferCount.ToString() : "N/A"));
				xnyu_details.Add("Culling Mask: " + ((world_cam != null) ? world_cam.Camera.cullingMask.ToString() : "N/A"));
				xnyu_details.Add("Depth: " + ((world_cam != null) ? world_cam.Camera.depth.ToString() : "N/A"));
				xnyu_details.Add("Velocity: " + ((world_cam != null) ? world_cam.Camera.velocity.ToString() : "N/A"));
				xnyu_details.Add("Event Mask: " + ((world_cam != null) ? world_cam.Camera.eventMask.ToString() : "N/A"));
				xnyu_details.Add("Far Clip Plane: " + ((world_cam != null) ? world_cam.Camera.farClipPlane.ToString() : "N/A"));
				xnyu_details.Add("Field Of View: " + ((world_cam != null) ? world_cam.Camera.fieldOfView.ToString() : "N/A"));
				xnyu_details.Add("HDR: " + ((world_cam != null) ? world_cam.Camera.hdr.ToString() : "N/A"));
				xnyu_details.Add("Near Clip Plane: " + ((world_cam != null) ? world_cam.Camera.nearClipPlane.ToString() : "N/A"));
				xnyu_details.Add("Stereo Convergence: " + ((world_cam != null) ? world_cam.Camera.stereoConvergence.ToString() : "N/A"));
				xnyu_details.Add("Stereo Enabled: " + ((world_cam != null) ? world_cam.Camera.stereoEnabled.ToString() : "N/A"));
			}

			if(xnyu_details_toggles[8]){
				//Soulflame Data
				xnyu_details.Add("-Soulflame Data-");
				xnyu_details.Add("Soulflame Position: " + ((ori_object != null) ? ori_object.SoulFlame.SoulFlamePosition.ToString() : "N/A"));
				xnyu_details.Add("Soulflame Cooldown: " + ((ori_object != null) ? ori_object.SoulFlame.CooldownRemaining.ToString() : "N/A"));
				xnyu_details.Add("Soulflame Hold Duration: " + ((ori_object != null) ? ori_object.SoulFlame.HoldDownDuration.ToString() : "N/A"));
				xnyu_details.Add("Bar Value: " + ((ori_object != null) ? ori_object.SoulFlame.BarValue.ToString() : "N/A"));
				xnyu_details.Add("Acces to skill tree: " + ((ori_object != null) ? ori_object.SoulFlame.AllowedToAccessSkillTree.ToString() : "N/A"));
				xnyu_details.Add("Can Afford Soulflame: " + ((ori_object != null) ? ori_object.SoulFlame.CanAffordSoulFlame.ToString() : "N/A"));
				xnyu_details.Add("Inside Checkpoint: " + ((ori_object != null) ? ori_object.SoulFlame.InsideCheckpointMarker.ToString() : "N/A"));
				xnyu_details.Add("Lock Soulflame: " + ((ori_object != null) ? ori_object.SoulFlame.LockSoulFlame.ToString() : "N/A"));
				xnyu_details.Add("Could Soulflame: " + ((ori_object != null) ? ori_object.SoulFlame.PlayerCouldSoulFlame.ToString() : "N/A"));
			}


			
			if(xnyu_details.Count > 21){
				details_box_height = 22f;
			}else{
				details_box_height = (float)xnyu_details.Count;
			}
			details_box_width = (float)Math.Floor(((float)xnyu_details.Count / 22f) - 0.0001f) + 1f;

		}

		CameraController WorldCam = UnityEngine.Object.FindObjectOfType<CameraController>();

		//Prepare Enemy Debug Data
		if(GlobalEnemyDebug && !xnyu_menu_enabled && GlobalEnemyDebugSlowDown == 0){
			//Clear List
			if(GlobalEnemyDebugIndexCounter == 0){

			if(GlobalEnemyList.Count > 0) GlobalEnemyList.Clear();

			StarSlugEnemy[] star_slugs = FindObjectsOfType<StarSlugEnemy>();
			foreach(StarSlugEnemy star_slug in star_slugs){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(star_slug.transform.position, star_slug.StartPosition, star_slug.DamageDealer.Damage, star_slug.DamageDealer.PlayerOnly, star_slug.InsideFrustum, star_slug.FrustrumOptimized, star_slug.IsInWater, star_slug.BoundingBox, WorldCam));
			}

			AcidSlugEnemy[] acid_slugs = FindObjectsOfType<AcidSlugEnemy>();
			foreach(AcidSlugEnemy acid_slug in acid_slugs){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(acid_slug.transform.position, acid_slug.StartPosition, acid_slug.DamageDealer.Damage, acid_slug.DamageDealer.PlayerOnly, acid_slug.InsideFrustum, acid_slug.FrustrumOptimized, acid_slug.IsInWater, acid_slug.BoundingBox, WorldCam));
			}

			}

			if(GlobalEnemyDebugIndexCounter == 1){

			ArmouredRammingEnemy[] arm_rammings = FindObjectsOfType<ArmouredRammingEnemy>();
			foreach(ArmouredRammingEnemy arm_ramming in arm_rammings){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(arm_ramming.transform.position, arm_ramming.StartPosition, arm_ramming.DamageDealer.Damage, arm_ramming.DamageDealer.PlayerOnly, arm_ramming.InsideFrustum, arm_ramming.FrustrumOptimized, arm_ramming.IsInWater, arm_ramming.BoundingBox, WorldCam));
			}

			DashOwlEnemy[] dash_owls = FindObjectsOfType<DashOwlEnemy>();
			foreach(DashOwlEnemy dash_owl in dash_owls){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(dash_owl.transform.position, dash_owl.StartPosition, dash_owl.DamageDealer.Damage, dash_owl.DamageDealer.PlayerOnly, dash_owl.InsideFrustum, dash_owl.FrustrumOptimized, dash_owl.IsInWater, dash_owl.BoundingBox, WorldCam));
			}

			}

			if(GlobalEnemyDebugIndexCounter == 2){

			DropSlugEnemy[] drop_slugs = FindObjectsOfType<DropSlugEnemy>();
			foreach(DropSlugEnemy drop_slug in drop_slugs){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(drop_slug.transform.position, drop_slug.StartPosition, drop_slug.DamageDealer.Damage, drop_slug.DamageDealer.PlayerOnly, drop_slug.InsideFrustum, drop_slug.FrustrumOptimized, drop_slug.IsInWater, drop_slug.BoundingBox, WorldCam));
			}

			FishEnemy[] fishs = FindObjectsOfType<FishEnemy>();
			foreach(FishEnemy fish in fishs){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(fish.transform.position, fish.StartPosition, fish.DamageDealer.Damage, fish.DamageDealer.PlayerOnly, fish.InsideFrustum, fish.FrustrumOptimized, fish.IsInWater, fish.BoundingBox, WorldCam));
			}

			}

			if(GlobalEnemyDebugIndexCounter == 3){

			FloatingRockLaserEnemy[] frock_lasers = FindObjectsOfType<FloatingRockLaserEnemy>();
			foreach(FloatingRockLaserEnemy frock_laser in frock_lasers){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(frock_laser.transform.position, frock_laser.StartPosition, frock_laser.DamageDealer.Damage, frock_laser.DamageDealer.PlayerOnly, frock_laser.InsideFrustum, frock_laser.FrustrumOptimized, frock_laser.IsInWater, frock_laser.BoundingBox, WorldCam));
			}

			FloatingRockTurretEnemy[] frock_turrets = FindObjectsOfType<FloatingRockTurretEnemy>();
			foreach(FloatingRockTurretEnemy frock_turret in frock_turrets){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(frock_turret.transform.position, frock_turret.StartPosition, frock_turret.DamageDealer.Damage, frock_turret.DamageDealer.PlayerOnly, frock_turret.InsideFrustum, frock_turret.FrustrumOptimized, frock_turret.IsInWater, frock_turret.BoundingBox, WorldCam));
			}

			}

			if(GlobalEnemyDebugIndexCounter == 4){

			GroundEnemy[] grounds = FindObjectsOfType<GroundEnemy>();
			foreach(GroundEnemy ground in grounds){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(ground.transform.position, ground.StartPosition, ground.DamageDealer.Damage, ground.DamageDealer.PlayerOnly, ground.InsideFrustum, ground.FrustrumOptimized, ground.IsInWater, ground.BoundingBox, WorldCam));
			}

			JumperEnemy[] jumpers = FindObjectsOfType<JumperEnemy>();
			foreach(JumperEnemy jumper in jumpers){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(jumper.transform.position, jumper.StartPosition, jumper.DamageDealer.Damage, jumper.DamageDealer.PlayerOnly, jumper.InsideFrustum, jumper.FrustrumOptimized, jumper.IsInWater, jumper.BoundingBox, WorldCam));
			}

			}

			if(GlobalEnemyDebugIndexCounter == 5){

			KamikazeSootEnemy[] kamikaze_soots = FindObjectsOfType<KamikazeSootEnemy>();
			foreach(KamikazeSootEnemy kamikaze_soot in kamikaze_soots){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(kamikaze_soot.transform.position, kamikaze_soot.StartPosition, kamikaze_soot.DamageDealer.Damage, kamikaze_soot.DamageDealer.PlayerOnly, kamikaze_soot.InsideFrustum, kamikaze_soot.FrustrumOptimized, kamikaze_soot.IsInWater, kamikaze_soot.BoundingBox, WorldCam));
			}

			MortarWormEnemy[] mortar_worms = FindObjectsOfType<MortarWormEnemy>();
			foreach(MortarWormEnemy mortar_worm in mortar_worms){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(mortar_worm.transform.position, mortar_worm.StartPosition, mortar_worm.DamageDealer.Damage, mortar_worm.DamageDealer.PlayerOnly, mortar_worm.InsideFrustum, mortar_worm.FrustrumOptimized, mortar_worm.IsInWater, mortar_worm.BoundingBox, WorldCam));
			}


			}

		if(GlobalEnemyDebugIndexCounter == 6){


			OwlEnemy[] owls = FindObjectsOfType<OwlEnemy>();
			foreach(OwlEnemy owl in owls){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(owl.transform.position, owl.StartPosition, owl.DamageDealer.Damage, owl.DamageDealer.PlayerOnly, owl.InsideFrustum, owl.FrustrumOptimized, owl.IsInWater, owl.BoundingBox, WorldCam));
			}

			RammingEnemy[] rammings = FindObjectsOfType<RammingEnemy>();
			foreach(RammingEnemy ramming in rammings){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(ramming.transform.position, ramming.StartPosition, ramming.DamageDealer.Damage, ramming.DamageDealer.PlayerOnly, ramming.InsideFrustum, ramming.FrustrumOptimized, ramming.IsInWater, ramming.BoundingBox, WorldCam));
			}


		}

		if(GlobalEnemyDebugIndexCounter == 7){


			SlugEnemy[] slugs = FindObjectsOfType<SlugEnemy>();
			foreach(SlugEnemy slug in slugs){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(slug.transform.position, slug.StartPosition, slug.DamageDealer.Damage, slug.DamageDealer.PlayerOnly, slug.InsideFrustum, slug.FrustrumOptimized, slug.IsInWater, slug.BoundingBox, WorldCam));
			}

			SpitterEnemy[] spitters = FindObjectsOfType<SpitterEnemy>();
			foreach(SpitterEnemy spitter in spitters){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(spitter.transform.position, spitter.StartPosition, spitter.DamageDealer.Damage, spitter.DamageDealer.PlayerOnly, spitter.InsideFrustum, spitter.FrustrumOptimized, spitter.IsInWater, spitter.BoundingBox, WorldCam));
			}


		}

		if(GlobalEnemyDebugIndexCounter == 8){


			SwarmEnemy[] swarms = FindObjectsOfType<SwarmEnemy>();
			foreach(SwarmEnemy swarm in swarms){
			GlobalEnemyList.Add(new xNyuDebugEnemyData(swarm.transform.position, swarm.StartPosition, swarm.DamageDealer.Damage, swarm.DamageDealer.PlayerOnly, swarm.InsideFrustum, swarm.FrustrumOptimized, swarm.IsInWater, swarm.BoundingBox, WorldCam));
			}

			WormEnemy[] worms = FindObjectsOfType<WormEnemy>();
			foreach(WormEnemy worm in worms){
				GlobalEnemyList.Add(new xNyuDebugEnemyData(worm.transform.position, worm.StartPosition, worm.DamageDealer.Damage, worm.DamageDealer.PlayerOnly, worm.InsideFrustum, worm.FrustrumOptimized, worm.IsInWater, worm.BoundingBox, WorldCam));
			}

		}



		}

		//Prepare Door Debug Data
		if(GlobalDoorDebug && !xnyu_menu_enabled && GlobalDebugSlowDown == 0){
			//Clear List
			if(GlobalDoorList.Count > 0) GlobalDoorList.Clear();
			
			EnergyDoor[] energy_doors = FindObjectsOfType<EnergyDoor>();
			foreach(EnergyDoor energy_door in energy_doors){
				GlobalDoorList.Add(new xNyuDebugDoorData(energy_door.transform.position, "Energy Required: " + energy_door.AmountOfEnergyRequired.ToString(), "Energy Used: " + energy_door.AmountOfEnergyUsed.ToString(), "Distance to Sein: " + energy_door.DistanceToSein.ToString(), "Sein In Range: " + energy_door.SeinInRange.ToString(), "Ori Has Targets: " + energy_door.OriHasTargets.ToString(), WorldCam));
			}

			DoorWithSlots[] slot_doors = FindObjectsOfType<DoorWithSlots>();
			foreach(DoorWithSlots slot_door in slot_doors){
				GlobalDoorList.Add(new xNyuDebugDoorData(slot_door.transform.position, "Orbs Required: " + slot_door.NumberOfOrbsRequired.ToString(), "Orbs Used: " + slot_door.NumberOfOrbsUsed.ToString(), "Distance to Sein: " + slot_door.DistanceToSein.ToString(), "Sein In Range: " + slot_door.SeinInRange.ToString(), "Ori Has Targets: " + slot_door.OriHasTargets.ToString(), WorldCam));
			}

		}

		//Prepare Teleporter Debug Data
		if(GlobalTeleporterDebug && !xnyu_menu_enabled && GlobalDebugSlowDown == 0){
			//Clear List
			if(GlobalTeleporterList.Count > 0) GlobalTeleporterList.Clear();
			
			TeleporterController teleporter_controller = FindObjectOfType<TeleporterController>();
			foreach(GameMapTeleporter teleporter in teleporter_controller.Teleporters){
				GlobalTeleporterList.Add(new xNyuDebugTeleporterData(teleporter.WorldPosition, "Activated: " + teleporter.Activated.ToString(), "Identifier: " + teleporter.Identifier.ToString(), "Name: " + teleporter.Name.name.ToString(), "Area Name: " + teleporter.Area.Area.AreaNameString.ToString(), WorldCam));
			}

		}

		//Prepare Collectable Debug Data
		if(GlobalCollectablesDebug && !xnyu_menu_enabled && GlobalDebugSlowDown == 0){
			//Clear List
			if(GlobalCollectableDebugIndexCounter == 0){

			if(GlobalCollectableList.Count > 0) GlobalCollectableList.Clear();
			
			MapStone[] mapstones = FindObjectsOfType<MapStone>();
			foreach(MapStone mapstone in mapstones){
				GlobalCollectableList.Add(new xNyuDebugCollectableData(mapstone.transform.position, "Ori Duration: " + mapstone.OriDuration.ToString(), "Ori Target: " + mapstone.OriTarget.position.ToString(), "Distance to Sein: " + mapstone.DistanceToSein.ToString(), "Sein In Range: " + mapstone.CurrentState.ToString(), "Ori Has Targets: " + mapstone.OriHasTargets.ToString(), WorldCam));
			}

			KeystonePickup[] keystones = FindObjectsOfType<KeystonePickup>();
			foreach(KeystonePickup keystone in keystones){
				GlobalCollectableList.Add(new xNyuDebugCollectableData(keystone.transform.position, "Amount: " + keystone.Amount.ToString(), "Is Collected: " + keystone.IsCollected.ToString(), "Name: " + keystone.name.ToString(), "Completor Position: " + keystone.AreaCompletorPosition.ToString(), "Destroy on Collect: " + keystone.DestroyOnCollect.ToString(), WorldCam));
			}

			}
			
			if(GlobalCollectableDebugIndexCounter == 0){

			MapStonePickup[] mapstone_pickups = FindObjectsOfType<MapStonePickup>();
			foreach(MapStonePickup mapstone_pickup in mapstone_pickups){
				GlobalCollectableList.Add(new xNyuDebugCollectableData(mapstone_pickup.transform.position, "Amount: " + mapstone_pickup.Amount.ToString(), "Is Collected: " + mapstone_pickup.IsCollected.ToString(), "Name: " + mapstone_pickup.name.ToString(), "Collect Delay: " + mapstone_pickup.DelayBeforeCollectable.ToString(), "Destroy on Collect: " + mapstone_pickup.DestroyOnCollect.ToString(), WorldCam));
			}

			MaxEnergyContainerPickup[] maxenergys = FindObjectsOfType<MaxEnergyContainerPickup>();
			foreach(MaxEnergyContainerPickup maxenergy in maxenergys){
				GlobalCollectableList.Add(new xNyuDebugCollectableData(maxenergy.transform.position, "Amount: " + maxenergy.Amount.ToString(), "Is Collected: " + maxenergy.IsCollected.ToString(), "Name: " + maxenergy.name.ToString(), "Collect Delay: " + maxenergy.DelayBeforeCollectable.ToString(), "Destroy on Collect: " + maxenergy.DestroyOnCollect.ToString(), WorldCam));
			}

			}

			
			if(GlobalCollectableDebugIndexCounter == 0){

			MaxHealthContainerPickup[] maxhealths = FindObjectsOfType<MaxHealthContainerPickup>();
			foreach(MaxHealthContainerPickup maxhealth in maxhealths){
				GlobalCollectableList.Add(new xNyuDebugCollectableData(maxhealth.transform.position, "Inside Frustum: " + maxhealth.InsideFrustum.ToString(), "Is Collected: " + maxhealth.IsCollected.ToString(), "Name: " + maxhealth.name.ToString(), "Collect Delay: " + maxhealth.DelayBeforeCollectable.ToString(), "Destroy on Collect: " + maxhealth.DestroyOnCollect.ToString(), WorldCam));
			}

			ExpOrbPickup[] exporbs = FindObjectsOfType<ExpOrbPickup>();
			foreach(ExpOrbPickup exporb in exporbs){
				GlobalCollectableList.Add(new xNyuDebugCollectableData(exporb.transform.position, "Inside Frustum: " + exporb.InsideFrustum.ToString(), "Is Collected: " + exporb.IsCollected.ToString(), "Name: " + exporb.name.ToString(), "Collect Delay: " + exporb.DelayBeforeCollectable.ToString(), "Destroy on Collect: " + exporb.DestroyOnCollect.ToString(), WorldCam));
			}

			}

		}

		//Set and Reset Global Debug Slow Down
		if(GlobalEnemyDebugIndexCounter >= 8){
			GlobalEnemyDebugIndexCounter = 0;
		}else{
			GlobalEnemyDebugIndexCounter++;
		}

		if(GlobalCollectableDebugIndexCounter >= 3){
			GlobalCollectableDebugIndexCounter = 0;
		}else{
			GlobalCollectableDebugIndexCounter++;
		}

		GlobalEnemyDebugSlowDown++;
		if(GlobalEnemyDebugSlowDown >= 2) GlobalEnemyDebugSlowDown = 0;
		GlobalDebugSlowDown++;
		if(GlobalDebugSlowDown >= 3) GlobalDebugSlowDown = 0;
		DetailsSlowDown++;
		if(DetailsSlowDown >= 2) DetailsSlowDown = 0;

		
		




	}

	public bool HotkeyToFunc(string command){
		//Set lowe case
		command = command.ToLower();

		//Activate the set Hotkey
		Camera hotkey_cam = FindObjectOfType<CameraController>().Camera;
		SeinCharacter hotkey_sein_character = FindObjectOfType<SeinCharacter>();
		SeinController hotkey_sein_controller = FindObjectOfType<SeinController>();
		TeleporterController hotkey_teleporter_controller = FindObjectOfType<TeleporterController>();

		//Allow Rapid Press
		bool allowPressMore = false;

		//Find Arguments
		List<string> hotkey_arguments = new List<string>();
		if(command[command.IndexOf("(")+1] != ')'){
			string sub_arguments = command.Replace(command.Substring(0, command.IndexOf("(") + 1), "");
			sub_arguments = sub_arguments.Replace(")", "");
			string[] h_args = sub_arguments.Split(',');

			for(int i = 0; i < h_args.Length; i++){
				hotkey_arguments.Add(h_args[i].Replace(" ", ""));
			}
		}

		if(command.Contains("camera.fieldofview")){
			hotkey_cam.fieldOfView += float.Parse(hotkey_arguments[0]);
			allowPressMore = true;
		}else if(command.Contains("camera.aspect")){
			hotkey_cam.aspect += float.Parse(hotkey_arguments[0]);
			allowPressMore = true;
		}else if(command.Contains("camera.aspect")){
			hotkey_cam.depth += float.Parse(hotkey_arguments[0]);
			allowPressMore = true;
		}else if(command.Contains("camera.aspect")){
			hotkey_cam.farClipPlane += float.Parse(hotkey_arguments[0]);
			allowPressMore = true;
		}else if(command.Contains("camera.removeallcommandbuffers")){
			hotkey_cam.RemoveAllCommandBuffers();
			allowPressMore = false;
		}else if(command.Contains("camera.resetaspect")){
			hotkey_cam.ResetAspect();
			allowPressMore = false;
		}else if(command.Contains("camera.resetfieldofview")){
			hotkey_cam.ResetFieldOfView();
			allowPressMore = false;
		}else if(command.Contains("camera.resetprojectionmatrix")){
			hotkey_cam.ResetProjectionMatrix();
			allowPressMore = false;
		}else if(command.Contains("camera.resetreplacementshader")){
			hotkey_cam.ResetReplacementShader();
			allowPressMore = false;
		}else if(command.Contains("camera.resetstereoprojectionmatrices")){
			hotkey_cam.ResetStereoProjectionMatrices();
			allowPressMore = false;
		}else if(command.Contains("camera.resetstereoviewmatrix")){
			hotkey_cam.ResetStereoViewMatrices();
			allowPressMore = false;
		}else if(command.Contains("camera.resetworldtocameramatrix")){
			hotkey_cam.ResetWorldToCameraMatrix();
			allowPressMore = false;
		}else if(command.Contains("seincharacter.resetairlimits")){
			hotkey_sein_character.ResetAirLimits();
			allowPressMore = false;
		}else if(command.Contains("seincharacter.placeonground")){
			hotkey_sein_character.PlaceOnGround();
			allowPressMore = false;
		}else if(command.Contains("seincontroller.enterplayinganimation")){
			hotkey_sein_controller.EnterPlayingAnimation();
			allowPressMore = false;
		}else if(command.Contains("seincontroller.handlejumping")){
			hotkey_sein_controller.HandleJumping();
			allowPressMore = false;
		}else if(command.Contains("seincontroller.handleoffscreenissue")){
			hotkey_sein_controller.HandleOffscreenIssue();
			allowPressMore = false;
		}else if(command.Contains("seincontroller.ongothroughportal")){
			hotkey_sein_controller.OnGoThroughPortal();
			allowPressMore = false;
		}else if(command.Contains("seincontroller.performjump")){
			hotkey_sein_controller.PerformJump();
			allowPressMore = false;
		}else if(command.Contains("seincontroller.shouldanimationkeepplaying")){
			hotkey_sein_controller.ShouldAnimationKeepPlaying();
			allowPressMore = false;
		}else if(command.Contains("seincontroller.stopanimation")){
			hotkey_sein_controller.StopAnimation();
			allowPressMore = false;
		}else if(command.Contains("seincontroller.updatemovementstuff")){
			hotkey_sein_controller.UpdateMovementStuff();
			allowPressMore = false;
		}else if(command.Contains("seincontroller.updateoriactivestate")){
			hotkey_sein_controller.UpdateOriActiveState();
			allowPressMore = false;
		}else if(command.Contains("seincontroller.isplayinganimation")){
			bool to_set = !hotkey_sein_controller.IsPlayingAnimation;
			if(hotkey_arguments.Count > 0) to_set = bool.Parse(hotkey_arguments[0]);
			hotkey_sein_controller.IsPlayingAnimation = to_set;
			allowPressMore = false;
		}else if(command.Contains("seincontroller.ignorecontrollerinput")){
			bool to_set = !hotkey_sein_controller.IgnoreControllerInput;
			if(hotkey_arguments.Count > 0) to_set = bool.Parse(hotkey_arguments[0]);
			hotkey_sein_controller.IgnoreControllerInput = to_set;
			allowPressMore = false;
		}else if(command.Contains("seincontroller.lockmovementinput")){
			bool to_set = !hotkey_sein_controller.LockMovementInput;
			if(hotkey_arguments.Count > 0) to_set = bool.Parse(hotkey_arguments[0]);
			hotkey_sein_controller.LockMovementInput = to_set;
			allowPressMore = false;
		}else if(command.Contains("debugb.suspendgameplay")){
			DebugMenuB.SuspendGameplay();
			allowPressMore = false;
		}else if(command.Contains("debugb.resumegameplay")){
			DebugMenuB.ResumeGameplay();
			allowPressMore = false;
		}else if(command.Contains("teleportercontroller.begin")){
			TeleporterController.BeginTeleportation(hotkey_teleporter_controller.Teleporters[int.Parse(hotkey_arguments[0])]);
			allowPressMore = false;
		}







		return allowPressMore;

	}

	public void Start()
	{
		xnyu_details_toggles[0] = false;
		xnyu_details_toggles[1] = false;
		xnyu_details_toggles[2] = false;
		xnyu_details_toggles[3] = false;
		xnyu_details_toggles[4] = false;
		xnyu_details_toggles[5] = false;
		xnyu_details_toggles[6] = false;
		xnyu_details_toggles[7] = false;
		xnyu_details_toggles[8] = false;

		xnyu_debug_toggles[0] = false;
		xnyu_debug_toggles[1] = false;
		xnyu_debug_toggles[2] = false;
		xnyu_debug_toggles[3] = false;
		xnyu_debug_toggles[4] = false;
		xnyu_debug_toggles[5] = false;

		xnyu_menu_enabled = false;

		key_can_press[0] = true;
		key_can_press[1] = true;
		key_can_press[2] = true;
		key_can_press[3] = true;
		key_can_press[4] = true;
		key_can_press[5] = true;
		key_can_press[6] = true;
		key_can_press[7] = true;
		key_can_press[8] = true;
		key_can_press[9] = true;
		key_can_press[10] = true;
		key_can_press[11] = true;
		key_can_press[12] = true;
		key_can_press[13] = true;
		key_can_press[14] = true;
		key_can_press[15] = true;
		key_can_press[16] = true;

		fixed_size_w = 1920f;
		fixed_size_h = 1080f;
		width = (float)Screen.width;
		height = (float)Screen.height;
		scr_scale_w = width / fixed_size_w;
		scr_scale_h = width / fixed_size_h;
		f_size = (int)(13f * scr_scale_w);
		f_dbg_size = (int)(9f * scr_scale_w);
		f_title_size = (int)(25f * scr_scale_w);

		DebugDrawX = width/2 - 100f;
		DebugDrawY = height/2 - 60f;

		font_white = new GUIStyle();
		font_white.fontSize = f_size;
		font_white.normal.textColor = Color.white;
		font_red = new GUIStyle();
		font_red.fontSize = f_size;
		font_red.normal.textColor = Color.red;
		font_green = new GUIStyle();
		font_green.fontSize = f_size;
		font_green.normal.textColor = Color.green;
		font_blue = new GUIStyle();
		font_blue.fontSize = f_size;
		font_blue.normal.textColor = Color.cyan;
		font_yellow = new GUIStyle();
		font_yellow.fontSize = f_size;
		font_yellow.normal.textColor = Color.yellow;
		font_purple = new GUIStyle();
		font_purple.fontSize = f_size;
		font_purple.normal.textColor = Color.magenta;
		font_gray = new GUIStyle();
		font_gray.fontSize = f_size;
		font_gray.normal.textColor = Color.gray;
		font_dbg_blue = new GUIStyle();
		font_dbg_blue.fontSize = f_dbg_size;
		font_dbg_blue.normal.textColor = Color.cyan;
		font_title_red = new GUIStyle();
		font_title_red.fontSize = f_title_size;
		font_title_red.normal.textColor = Color.red;
		font_title_yellow = new GUIStyle();
		font_title_yellow.fontSize = f_title_size - 5;
		font_title_yellow.normal.textColor = Color.yellow;

		WorldCameraDraw = FindObjectOfType<CameraController>().Camera;

		//Directory and Settings create
		if(!Directory.Exists(settings_dir)) Directory.CreateDirectory(settings_dir);
		if(!File.Exists(settings_file)){
			string[] lines = new string[17];

			lines[0] = "NUM_1:Camera.FieldOfView(50)";
			lines[1] = "NUM_2:Camera.Aspect(50)";
			lines[2] = "NUM_3:Camera.Depth(50)";
			lines[3] = "NUM_4:Camera.RemoveallCommandBuffers()";
			lines[4] = "NUM_5:Camera.ResetFieldOfView()";
			lines[5] = "NUM_6:Camera.ResetAspect()";
			lines[6] = "NUM_7:Camera.ResetAspect()";
			lines[7] = "NUM_8:None";
			lines[8] = "NUM_9:None";
			lines[9] = "F1:None";
			lines[10] = "F2:None";
			lines[11] = "F3:None";
			lines[12] = "F4:None";
			lines[13] = "F5:None";
			lines[14] = "F6:None";
			lines[15] = "F7:None";
			lines[16] = "F8:None";

			File.WriteAllLines(settings_file, lines);
		}

		string[] key_settings_lines = File.ReadAllLines(settings_file);

		//Read Key Settings
		for(int i = 0; i < key_settings_lines.Length; i++){
			key_settings[i] = key_settings_lines[i].Split(':')[1];
		}

		//Hotkey Functions List
		List<string> Funcs_Nothing = new List<string>();
		Funcs_Nothing.Add("-Nothing-");
		Funcs_Nothing.Add("None");

		List<string> Funcs_Camera_Properties = new List<string>();
		Funcs_Camera_Properties.Add("-Camera Properties-");
		Funcs_Camera_Properties.Add("Camera.FieldOfView(100)");
		Funcs_Camera_Properties.Add("Camera.Aspect(15)");
		Funcs_Camera_Properties.Add("Camera.Depth(-45)");
		Funcs_Camera_Properties.Add("Camera.darclipplane(-10)");

		List<string> Funcs_Camera_Methods = new List<string>();
		Funcs_Camera_Methods.Add("-Camera Methods-");
		Funcs_Camera_Methods.Add("Camera.RemoveAllCommandBuffers");
		Funcs_Camera_Methods.Add("Camera.ResetAspect()");
		Funcs_Camera_Methods.Add("Camera.ResetFieldOfView()");
		Funcs_Camera_Methods.Add("Camera.ResetAspect()");
		Funcs_Camera_Methods.Add("Camera.ResetFieldOfView()");
		Funcs_Camera_Methods.Add("Camera.ResetProjectionMatrix()");
		Funcs_Camera_Methods.Add("Camera.ResetReplacementShader()");
		Funcs_Camera_Methods.Add("Camera.ResetStereoProjectionMatrices()");
		Funcs_Camera_Methods.Add("Camera.ResetStereoViewMatrices()");
		Funcs_Camera_Methods.Add("Camera.ResetWorldToCameraMatrix()");

		List<string> Funcs_Sein_Character_methods = new List<string>();
		Funcs_Sein_Character_methods.Add("-Sein Character Methods-");
		Funcs_Sein_Character_methods.Add("SeinCharacter.ResetAirLimits()");
		Funcs_Sein_Character_methods.Add("SeinCharacter.PlaceOnGround()");

		List<string> Funcs_Sein_Controller_Properties = new List<string>();
		Funcs_Sein_Controller_Properties.Add("-Sein Controller Properties-");
		Funcs_Sein_Controller_Properties.Add("SeinController.IsPlayingAnimation()");
		Funcs_Sein_Controller_Properties.Add("SeinController.IgnoreControllerInput()");
		Funcs_Sein_Controller_Properties.Add("SeinController.LockedMovementInput()");

		List<string> Funcs_Sein_Controller_Methods = new List<string>();
		Funcs_Sein_Controller_Methods.Add("-Sein Controller Methods-");
		Funcs_Sein_Controller_Methods.Add("SeinController.EnterPlayingAnimation()");
		Funcs_Sein_Controller_Methods.Add("SeinController.HandleJumping()");
		Funcs_Sein_Controller_Methods.Add("SeinController.HandleOffscreenIssue()");
		Funcs_Sein_Controller_Methods.Add("SeinController.OnGoThroughPortal()");
		Funcs_Sein_Controller_Methods.Add("SeinController.PerformJump()");
		Funcs_Sein_Controller_Methods.Add("SeinController.ShouldAnimationKeepPlaying()");
		Funcs_Sein_Controller_Methods.Add("SeinController.StopAnimation()");
		Funcs_Sein_Controller_Methods.Add("SeinController.UpdateMovementStuff()");
		Funcs_Sein_Controller_Methods.Add("SeinController.UpdateOriActivateState()");

		List<string> Funcs_Sein_Teleporter_Methods = new List<string>();
		Funcs_Sein_Teleporter_Methods.Add("-Teleporter Methods-");
		Funcs_Sein_Teleporter_Methods.Add("TeleporterController.BeginTeleportation(0)");

		List<string> Funcs_Sein_Special_Methods = new List<string>();
		Funcs_Sein_Special_Methods.Add("-Special Methods-");
		Funcs_Sein_Special_Methods.Add("DebugB.SuspendGameplay()");
		Funcs_Sein_Special_Methods.Add("DebugB.ResumeGameplay()");

		//Add the Lists
		Key_functions_list.Add(Funcs_Nothing);
		Key_functions_list.Add(Funcs_Camera_Properties);
		Key_functions_list.Add(Funcs_Camera_Methods);
		Key_functions_list.Add(Funcs_Sein_Character_methods);
		Key_functions_list.Add(Funcs_Sein_Controller_Properties);
		Key_functions_list.Add(Funcs_Sein_Controller_Methods);
		Key_functions_list.Add(Funcs_Sein_Special_Methods);
		Key_functions_list.Add(Funcs_Sein_Teleporter_Methods);





	}

	public string settings_dir = Directory.GetCurrentDirectory() + @"\xNyuDebug";

	public string settings_file = Directory.GetCurrentDirectory() + @"\xNyuDebug\key_settings.txt";

	public string[] key_settings = new string[17];

	public List<List<string>> Key_functions_list = new List<List<string>>();



	public bool key_binding_toggle = false;

	public int key_binding_index = 0;



	public bool[] key_can_press = new bool[17];



	public GUIStyle font_white;

	public GUIStyle font_red;

	public GUIStyle font_green;

	public GUIStyle font_blue;

	public GUIStyle font_purple;

	public GUIStyle font_yellow;

	public GUIStyle font_gray;

	public GUIStyle font_dbg_blue;

	public GUIStyle font_title_red;

	public GUIStyle font_title_yellow;



	public float fixed_size_w;

	public float fixed_size_h;

	public float width;

	public float height;

	public float scr_scale_w;

	public float scr_scale_h;

	public int f_size;

	public int f_dbg_size;

	public int f_title_size;



	public static float details_box_height;

	public static float details_box_width;



	public List<xNyuDebugEnemyData> GlobalEnemyList = new List<xNyuDebugEnemyData>();

	public List<xNyuDebugDoorData> GlobalDoorList = new List<xNyuDebugDoorData>();

	public List<xNyuDebugTeleporterData> GlobalTeleporterList = new List<xNyuDebugTeleporterData>();

	public List<xNyuDebugCollectableData> GlobalCollectableList = new List<xNyuDebugCollectableData>();


	public bool xnyu_menu_enabled;

	public bool xnyu_menu_key_select_enabled = false;

	public static DebugMenuB DebugMenuInstance = null;

	public static bool DebugMenuInit = false;

	public static bool DebugMenuIsOpen = false;

	public List<string> xnyu_details = new List<string>();

	public bool[] xnyu_details_toggles = new bool[9];

	public bool[] xnyu_debug_toggles = new bool[6];


	public static float DebugDrawX = 900f;

	public static float DebugDrawY = 450f;



	public bool GlobalDoorDebug = false;

	public bool GlobalTeleporterDebug = false;

	public bool GlobalTreeDebug = false;

	public bool GlobalEnemyDebug = false;

	public bool GlobalCollectablesDebug = false;



	public bool GlobalDoorDebugFirstInit = false;

	public bool GlobalTeleporterDebugFirstInit = false;

	public bool GlobalTreeDebugFirstInit = false;

	public bool GlobalEnemyDebugFirstInit = false;

	public bool GlobalCollectablesDebugFirstInit = false;



	public int GlobalDebugSlowDown = 0;

	public int GlobalEnemyDebugSlowDown = 0;

	public int GlobalEnemyDebugIndexCounter = 0;

	public int GlobalCollectableDebugIndexCounter = 0;

	public int DetailsSlowDown = 0;



	public Camera WorldCameraDraw;
}
