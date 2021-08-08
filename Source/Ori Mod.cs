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
			//GUI.Toggle(new Rect(DebugDrawX - 100f, DebugDrawY - 100f, 400f, 20f * scr_scale_h), xnyu_details_toggles[0], "World: " + debug_string, font_purple);

			//Title and Version
			GUI.Toggle(new Rect(DebugDrawX - (90f * scr_scale_w), 150f * scr_scale_h, 400f, 30f), xnyu_details_toggles[0], "Sein Debugger by xNyu", font_title_red);
			GUI.Toggle(new Rect(DebugDrawX - (25f * scr_scale_w), 195f * scr_scale_h, 400f, 30f), xnyu_details_toggles[0], "Version 1.1", font_title_yellow);

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
			GUI.Toggle(new Rect(80f * scr_scale_w, DebugDrawY + 20f * scr_scale_h, 200f, 20f * scr_scale_h), xnyu_details_toggles[1], "Gameobject Debug (Text/Control)", xnyu_debug_toggles[0] ? (xnyu_debug_toggles[1] ? font_green : font_red) : font_gray);

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

			//Global Object Debug Data
			if(GlobalObjectDebugTrigger && GlobalObjectDebug != null && GlobalObjectDebugText.Count > 0){
				Vector3 DrawCoordsy = WorldCameraDraw.WorldToScreenPoint(GlobalObjectDebug.transform.position);
				GUI.color = new Color(1f, 1f, 1f, 1f);
				GUI.Box(new Rect(DrawCoordsy.x, Screen.height - DrawCoordsy.y, 150f * scr_scale_w, 80f * scr_scale_h), "");
				for(int i = 0; i < GlobalObjectDebugText.Count; i++) GUI.Label(new Rect(DrawCoordsy.x + 5f, Screen.height - DrawCoordsy.y + (5f + ((float)i*10f)) * scr_scale_h, 130f * scr_scale_w, 10f * scr_scale_h), GlobalObjectDebugText[i], font_dbg_blue);
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
					if(xnyu_debug_toggles[0] && mouse.x > 80f * scr_scale_w && mouse.x < 80f * scr_scale_w + 200f * scr_scale_w && mouse.y < DebugDrawY + 40f * scr_scale_h && mouse.y > DebugDrawY + 20f * scr_scale_h) {xnyu_debug_toggles[1] = !xnyu_debug_toggles[1];}

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
			GlobalObjectDebugTrigger = xnyu_debug_toggles[1];
		}else{
			GlobalObjectDebugTrigger = false;
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
		if(!xnyu_menu_enabled && key_binding_toggle){
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

		//Details Slow Down
		if(!xnyu_menu_enabled){
			DetailsSlowDown++;
			if(DetailsSlowDown == 2) DetailsSlowDown = 0;
		}

		//CameraController WorldCam = UnityEngine.Object.FindObjectOfType<CameraController>();

		if(GlobalObjectDebugTrigger && !xnyu_menu_enabled){
				Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
				RaycastHit hit;

				if(Input.GetMouseButtonDown(0))
				{
					if(!GlobalObjectDebugSelected)
					{
						if(Physics.Raycast(ray, out hit))
						{
							GlobalObjectDebug = hit.transform.gameObject;
							GlobalObjectDebugSelected = true;
						}
					}
					else
					{
						GlobalObjectDebug = null;
						GlobalObjectDebugSelected = false;
						if(Physics.Raycast(ray, out hit))
						{
							GlobalObjectDebug = hit.transform.gameObject;
							GlobalObjectDebugSelected = true;
						}
					}
				}

				if(!GlobalObjectDebugSelected){
					GlobalObjectDebug = null;
					if(Physics.Raycast(ray, out hit))
					{
						GlobalObjectDebug = hit.transform.gameObject;
					}
				}else{
					if(Input.GetMouseButton(1))
					{
						Plane plane = new Plane(Vector3.forward, Vector3.zero);
						Vector3 planePosition;
						var m_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
						float enter;
 						if (plane.Raycast(m_ray, out enter))
						{
							planePosition = m_ray.GetPoint(enter);
							GlobalObjectDebug.transform.position = planePosition;
							if(GlobalObjectDebugMoveLock != Vector3.zero) GlobalObjectDebugMoveLock = planePosition;
						}
					}
					if(GlobalObjectDebugMoveLock != Vector3.zero) GlobalObjectDebug.transform.position = GlobalObjectDebugMoveLock;

					if(Input.GetKeyDown(KeyCode.LeftAlt)){
						if(GlobalObjectDebugMoveLock == Vector3.zero){
							GlobalObjectDebugMoveLock = GlobalObjectDebug.transform.position;
						}else{
							GlobalObjectDebugMoveLock = Vector3.zero;
						}
					}
				}

				if(GlobalObjectDebug != null){
					if(GlobalObjectDebugText.Count > 0) GlobalObjectDebugText.Clear();
					GlobalObjectDebugText.Add("Name: " + GlobalObjectDebug.name);
					GlobalObjectDebugText.Add("Position: " + GlobalObjectDebug.transform.position.ToString());
					GlobalObjectDebugText.Add("Angle: " + GlobalObjectDebug.transform.eulerAngles.ToString());

					if(GlobalObjectDebug.GetComponent<Enemy>() != null)
					{
						Enemy SpecificData = GlobalObjectDebug.GetComponent<Enemy>();
						GlobalObjectDebugText.Add("Start Position: " + SpecificData.StartPosition.ToString());
						GlobalObjectDebugText.Add("Facing Player: " + SpecificData.IsFacingPlayer.ToString());
						GlobalObjectDebugText.Add("HP: " + SpecificData.DamageReciever.Health.ToString() + "/" + SpecificData.DamageReciever.MaxHealth.ToString());
						GlobalObjectDebugText.Add("Bounce on Stomp: " + SpecificData.DamageReciever.BounceOnStomp.ToString());
						GlobalObjectDebugText.Add("Moon GUID: " + SpecificData.MoonGuid.ToString());
					}
					else if(GlobalObjectDebug.GetComponent<GameMapTeleporter>() != null)
					{
						GameMapTeleporter SpecificData = GlobalObjectDebug.GetComponent<GameMapTeleporter>();
						GlobalObjectDebugText.Add("Map Icon Position: " + SpecificData.AreaMapIconPosition.ToString());
						GlobalObjectDebugText.Add("Identifier: " + SpecificData.Identifier);
						GlobalObjectDebugText.Add("Activated: " + SpecificData.Activated.ToString());
					}
					else if(GlobalObjectDebug.GetComponent<DropPickup>() != null)
					{
						DropPickup SpecificData = GlobalObjectDebug.GetComponent<DropPickup>();
						GlobalObjectDebugText.Add("Gravity: " + SpecificData.Gravity.ToString());
						GlobalObjectDebugText.Add("State: " + SpecificData.CurrentState.ToString());
						GlobalObjectDebugText.Add("Falling Duration: " + SpecificData.FallingDuration);
						GlobalObjectDebugText.Add("Flash Duration: " + SpecificData.FlashDuration.ToString());
						GlobalObjectDebugText.Add("Hover Duration: " + SpecificData.HoverDuration.ToString());
					}
					else if(GlobalObjectDebug.GetComponent<MapStone>() != null)
					{
						MapStone SpecificData = GlobalObjectDebug.GetComponent<MapStone>();
						GlobalObjectDebugText.Add("Radius: " + SpecificData.Radius.ToString());
						GlobalObjectDebugText.Add("Distance to Sein: " + SpecificData.DistanceToSein.ToString());
					}
					else if(GlobalObjectDebug.GetComponent<MaxHealthContainerPickup>() != null)
					{
						MaxHealthContainerPickup SpecificData = GlobalObjectDebug.GetComponent<MaxHealthContainerPickup>();
						GlobalObjectDebugText.Add("Radius: " + SpecificData.Radius.ToString());
						GlobalObjectDebugText.Add("Collect Delay: " + SpecificData.DelayBeforeCollectable.ToString());
						GlobalObjectDebugText.Add("Destroy on Collect: " + SpecificData.DestroyOnCollect.ToString());
						GlobalObjectDebugText.Add("Collected: " + SpecificData.IsCollected.ToString());
					}
					else if(GlobalObjectDebug.GetComponent<MaxEnergyContainerPickup>() != null)
					{
						MaxEnergyContainerPickup SpecificData = GlobalObjectDebug.GetComponent<MaxEnergyContainerPickup>();
						GlobalObjectDebugText.Add("Radius: " + SpecificData.Radius.ToString());
						GlobalObjectDebugText.Add("Collect Delay: " + SpecificData.DelayBeforeCollectable.ToString());
						GlobalObjectDebugText.Add("Destroy on Collect: " + SpecificData.DestroyOnCollect.ToString());
						GlobalObjectDebugText.Add("Collected: " + SpecificData.IsCollected.ToString());
					}
					else if(GlobalObjectDebug.GetComponent<Door>() != null)
					{
						Door SpecificData = GlobalObjectDebug.GetComponent<Door>();
						GlobalObjectDebugText.Add("Create Checkpoint: " + SpecificData.CreateCheckpoint.ToString());
						GlobalObjectDebugText.Add("Other Door Name: " + SpecificData.OtherDoorName.ToString());
						GlobalObjectDebugText.Add("Scene Name: " + SpecificData.SceneRoot.MetaData.SceneName.ToString());
						GlobalObjectDebugText.Add("Transitions Delay: " + SpecificData.TransitionDelay.ToString());
					}
					else if(GlobalObjectDebug.GetComponent<SinMovingPlatform>() != null)
					{
						SinMovingPlatform SpecificData = GlobalObjectDebug.GetComponent<SinMovingPlatform>();
						GlobalObjectDebugText.Add("Sein-Naru Combo: " + SpecificData.Direction.ToString());
						GlobalObjectDebugText.Add("Dont Move When Deactivated: " + SpecificData.DontMoveWhenDeactivatedInitially.ToString());
						GlobalObjectDebugText.Add("Offset: " + SpecificData.Offset.ToString());
						GlobalObjectDebugText.Add("Period: " + SpecificData.Period.ToString());
						GlobalObjectDebugText.Add("Range: " + SpecificData.Range.ToString());
					}
					else if(GlobalObjectDebug.GetComponent<SequencePlatform>() != null)
					{
						SequencePlatform SpecificData = GlobalObjectDebug.GetComponent<SequencePlatform>();
						GlobalObjectDebugText.Add("Visible at Start: " + SpecificData.VisibleAtStart.ToString());
						GlobalObjectDebugText.Add("Next Platform Touch: " + SpecificData.NextPlatformOnTouch.ToString());
						GlobalObjectDebugText.Add("Delay Next Platform: " + SpecificData.DelayToNextPlatformAppear.ToString());
						GlobalObjectDebugText.Add("Vanish: " + SpecificData.Vanish.ToString());
						GlobalObjectDebugText.Add("Vanish on Touch: " + SpecificData.VanishOnTouch.ToString());
						GlobalObjectDebugText.Add("Delay to Vanish: " + SpecificData.DelayToVanish.ToString());
					}
					else if(GlobalObjectDebug.GetComponent<SequencePlatformB>() != null)
					{
						SequencePlatformB SpecificData = GlobalObjectDebug.GetComponent<SequencePlatformB>();
						GlobalObjectDebugText.Add("Visible at Start: " + SpecificData.VisibleAtStart.ToString());
						GlobalObjectDebugText.Add("Next Platform: " + SpecificData.NextPlatform.ToString());
					}
					else if(GlobalObjectDebug.GetComponent<Naru>() != null)
					{
						Naru SpecificData = GlobalObjectDebug.GetComponent<Naru>();
						GlobalObjectDebugText.Add("Sein-Naru Combo: " + SpecificData.SeinNaruComboEnabled.ToString());
						GlobalObjectDebugText.Add("On Ground: " + SpecificData.IsOnGround.ToString());
					}
					else if(GlobalObjectDebug.GetComponent<KillPlayer>() != null)
					{
						KillPlayer SpecificData = GlobalObjectDebug.GetComponent<KillPlayer>();
						GlobalObjectDebugText.Add("Kill Enemies Too: " + SpecificData.KillEnemiesToo.ToString());
					}

				}else{
					GlobalObjectDebugBox = new Rect(0, 0, 0, 0);
				}

		}


		
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


	public Vector3 GlobalObjectDebugMoveLock = Vector3.zero;

	public GameObject GlobalObjectDebug = null;

	public bool GlobalObjectDebugSelected = false;

	public List<string> GlobalObjectDebugText = new List<string>();

	public Rect GlobalObjectDebugBox = new Rect(0, 0, 0, 0);



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

	public bool GlobalObjectDebugTrigger = false;

	public bool GlobalCollectablesDebug = false;



	public int DetailsSlowDown = 0;



	public string debug_string = "";



	public Camera WorldCameraDraw;
}
