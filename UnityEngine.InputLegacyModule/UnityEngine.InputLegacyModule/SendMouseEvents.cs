using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public class SendMouseEvents : Object
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00003CAC File Offset: 0x00001EAC
		// Note: this type is marked as 'beforefieldinit'.
		static SendMouseEvents()
		{
			Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "SendMouseEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr);
			SendMouseEvents.NativeFieldInfoPtr_s_MouseUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "s_MouseUsed");
			SendMouseEvents.NativeFieldInfoPtr_m_LastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_LastHit");
			SendMouseEvents.NativeFieldInfoPtr_m_MouseDownHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_MouseDownHit");
			SendMouseEvents.NativeFieldInfoPtr_m_CurrentHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_CurrentHit");
			SendMouseEvents.NativeFieldInfoPtr_m_Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "m_Cameras");
			SendMouseEvents.NativeFieldInfoPtr_s_GetMouseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "s_GetMouseState");
			SendMouseEvents.NativeFieldInfoPtr_s_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "s_MousePosition");
			SendMouseEvents.NativeFieldInfoPtr_s_MouseButtonPressedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "s_MouseButtonPressedThisFrame");
			SendMouseEvents.NativeFieldInfoPtr_s_MouseButtonIsPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "s_MouseButtonIsPressed");
			SendMouseEvents.NativeMethodInfoPtr_UpdateMouse_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663362);
			SendMouseEvents.NativeMethodInfoPtr_SetMouseMoved_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663363);
			SendMouseEvents.NativeMethodInfoPtr_DoSendMouseEvents_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663364);
			SendMouseEvents.NativeMethodInfoPtr_SendEvents_Private_Static_Void_Int32_HitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, 100663365);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1267147, RefRangeEnd = 1267148, XrefRangeStart = 1267134, XrefRangeEnd = 1267147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateMouse()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.NativeMethodInfoPtr_UpdateMouse_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003E08 File Offset: 0x00002008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267148, XrefRangeEnd = 1267152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMouseMoved()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.NativeMethodInfoPtr_SetMouseMoved_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003E30 File Offset: 0x00002030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267152, XrefRangeEnd = 1267270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoSendMouseEvents(int skipRTCameras)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipRTCameras;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.NativeMethodInfoPtr_DoSendMouseEvents_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003E64 File Offset: 0x00002064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1267390, RefRangeEnd = 1267391, XrefRangeStart = 1267270, XrefRangeEnd = 1267390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendEvents(int i, SendMouseEvents.HitInfo hit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hit));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.NativeMethodInfoPtr_SendEvents_Private_Static_Void_Int32_HitInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002230 File Offset: 0x00000430
		public SendMouseEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00003EB0 File Offset: 0x000020B0
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002239 File Offset: 0x00000439
		public unsafe static bool s_MouseUsed
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_s_MouseUsed, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_s_MouseUsed, (void*)(&value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003ECC File Offset: 0x000020CC
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002247 File Offset: 0x00000447
		public unsafe static Il2CppReferenceArray<SendMouseEvents.HitInfo> m_LastHit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_m_LastHit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SendMouseEvents.HitInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_m_LastHit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003EF4 File Offset: 0x000020F4
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002259 File Offset: 0x00000459
		public unsafe static Il2CppReferenceArray<SendMouseEvents.HitInfo> m_MouseDownHit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_m_MouseDownHit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SendMouseEvents.HitInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_m_MouseDownHit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003F1C File Offset: 0x0000211C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000226B File Offset: 0x0000046B
		public unsafe static Il2CppReferenceArray<SendMouseEvents.HitInfo> m_CurrentHit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_m_CurrentHit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SendMouseEvents.HitInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_m_CurrentHit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003F44 File Offset: 0x00002144
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000227D File Offset: 0x0000047D
		public unsafe static Il2CppReferenceArray<Camera> m_Cameras
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_m_Cameras, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_m_Cameras, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003F6C File Offset: 0x0000216C
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000228F File Offset: 0x0000048F
		public unsafe static Func<KeyValuePair<int, Vector2>> s_GetMouseState
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_s_GetMouseState, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Vector2>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_s_GetMouseState, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003F94 File Offset: 0x00002194
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000022A1 File Offset: 0x000004A1
		public unsafe static Vector2 s_MousePosition
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_s_MousePosition, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_s_MousePosition, (void*)(&value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003FB0 File Offset: 0x000021B0
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000022AF File Offset: 0x000004AF
		public unsafe static bool s_MouseButtonPressedThisFrame
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_s_MouseButtonPressedThisFrame, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_s_MouseButtonPressedThisFrame, (void*)(&value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003FCC File Offset: 0x000021CC
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000022BD File Offset: 0x000004BD
		public unsafe static bool s_MouseButtonIsPressed
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SendMouseEvents.NativeFieldInfoPtr_s_MouseButtonIsPressed, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SendMouseEvents.NativeFieldInfoPtr_s_MouseButtonIsPressed, (void*)(&value));
			}
		}

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_s_MouseUsed;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_m_LastHit;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseDownHit;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentHit;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_m_Cameras;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_s_GetMouseState;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_s_MousePosition;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_s_MouseButtonPressedThisFrame;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_s_MouseButtonIsPressed;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMouse_Private_Static_Void_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_SetMouseMoved_Private_Static_Void_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_DoSendMouseEvents_Private_Static_Void_Int32_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_SendEvents_Private_Static_Void_Int32_HitInfo_0;

		// Token: 0x040000AD RID: 173
		public const int m_HitIndexGUI = 0;

		// Token: 0x040000AE RID: 174
		public const int m_HitIndexPhysics3D = 1;

		// Token: 0x040000AF RID: 175
		public const int m_HitIndexPhysics2D = 2;

		// Token: 0x02000026 RID: 38
		public sealed class HitInfo : ValueType
		{
			// Token: 0x060000F4 RID: 244 RVA: 0x0000478C File Offset: 0x0000298C
			// Note: this type is marked as 'beforefieldinit'.
			static HitInfo()
			{
				Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, "HitInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr);
				SendMouseEvents.HitInfo.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, "target");
				SendMouseEvents.HitInfo.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, "camera");
				SendMouseEvents.HitInfo.NativeMethodInfoPtr_SendMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, 100663367);
				SendMouseEvents.HitInfo.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_HitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, 100663368);
				SendMouseEvents.HitInfo.NativeMethodInfoPtr_Compare_Public_Static_Boolean_HitInfo_HitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr, 100663369);
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x0000481C File Offset: 0x00002A1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267125, XrefRangeEnd = 1267126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SendMessage(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.HitInfo.NativeMethodInfoPtr_SendMessage_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x00004864 File Offset: 0x00002A64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267126, XrefRangeEnd = 1267130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator bool(SendMouseEvents.HitInfo exists)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(exists));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.HitInfo.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_HitInfo_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x000048AC File Offset: 0x00002AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267130, XrefRangeEnd = 1267134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendMouseEvents.HitInfo.NativeMethodInfoPtr_Compare_Public_Static_Boolean_HitInfo_HitInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x000024E9 File Offset: 0x000006E9
			public HitInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x000024F2 File Offset: 0x000006F2
			public HitInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendMouseEvents.HitInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000FA RID: 250 RVA: 0x0000490C File Offset: 0x00002B0C
			// (set) Token: 0x060000FB RID: 251 RVA: 0x00002504 File Offset: 0x00000704
			public unsafe GameObject target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendMouseEvents.HitInfo.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendMouseEvents.HitInfo.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000FC RID: 252 RVA: 0x0000493C File Offset: 0x00002B3C
			// (set) Token: 0x060000FD RID: 253 RVA: 0x00002523 File Offset: 0x00000723
			public unsafe Camera camera
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendMouseEvents.HitInfo.NativeFieldInfoPtr_camera);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendMouseEvents.HitInfo.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000D8 RID: 216
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040000D9 RID: 217
			private static readonly IntPtr NativeFieldInfoPtr_camera;

			// Token: 0x040000DA RID: 218
			private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_0;

			// Token: 0x040000DB RID: 219
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_HitInfo_0;

			// Token: 0x040000DC RID: 220
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_HitInfo_HitInfo_0;
		}

		// Token: 0x02000027 RID: 39
		public enum LeftMouseButtonState
		{
			// Token: 0x040000DE RID: 222
			NotPressed,
			// Token: 0x040000DF RID: 223
			Pressed,
			// Token: 0x040000E0 RID: 224
			PressedThisFrame
		}
	}
}
