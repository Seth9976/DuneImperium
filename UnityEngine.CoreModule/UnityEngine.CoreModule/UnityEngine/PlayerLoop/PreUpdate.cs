using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x020001CC RID: 460
	[StructLayout(2)]
	public struct PreUpdate
	{
		// Token: 0x060020F8 RID: 8440 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		// Note: this type is marked as 'beforefieldinit'.
		static PreUpdate()
		{
			Il2CppClassPointerStore<PreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "PreUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x0000C90D File Offset: 0x0000AB0D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x020008CD RID: 2253
		[StructLayout(2)]
		public struct PhysicsUpdate
		{
			// Token: 0x06003A97 RID: 14999 RVA: 0x0001540E File Offset: 0x0001360E
			// Note: this type is marked as 'beforefieldinit'.
			static PhysicsUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.PhysicsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "PhysicsUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.PhysicsUpdate>.NativeClassPtr);
			}

			// Token: 0x06003A98 RID: 15000 RVA: 0x0001542E File Offset: 0x0001362E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.PhysicsUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008CE RID: 2254
		[StructLayout(2)]
		public struct Physics2DUpdate
		{
			// Token: 0x06003A99 RID: 15001 RVA: 0x00015440 File Offset: 0x00013640
			// Note: this type is marked as 'beforefieldinit'.
			static Physics2DUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.Physics2DUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "Physics2DUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.Physics2DUpdate>.NativeClassPtr);
			}

			// Token: 0x06003A9A RID: 15002 RVA: 0x00015460 File Offset: 0x00013660
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.Physics2DUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008CF RID: 2255
		[StructLayout(2)]
		public struct PhysicsClothUpdate
		{
			// Token: 0x06003A9B RID: 15003 RVA: 0x00015472 File Offset: 0x00013672
			// Note: this type is marked as 'beforefieldinit'.
			static PhysicsClothUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.PhysicsClothUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "PhysicsClothUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.PhysicsClothUpdate>.NativeClassPtr);
			}

			// Token: 0x06003A9C RID: 15004 RVA: 0x00015492 File Offset: 0x00013692
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.PhysicsClothUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D0 RID: 2256
		[StructLayout(2)]
		public struct CheckTexFieldInput
		{
			// Token: 0x06003A9D RID: 15005 RVA: 0x000154A4 File Offset: 0x000136A4
			// Note: this type is marked as 'beforefieldinit'.
			static CheckTexFieldInput()
			{
				Il2CppClassPointerStore<PreUpdate.CheckTexFieldInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "CheckTexFieldInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.CheckTexFieldInput>.NativeClassPtr);
			}

			// Token: 0x06003A9E RID: 15006 RVA: 0x000154C4 File Offset: 0x000136C4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.CheckTexFieldInput>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D1 RID: 2257
		[StructLayout(2)]
		public struct IMGUISendQueuedEvents
		{
			// Token: 0x06003A9F RID: 15007 RVA: 0x000154D6 File Offset: 0x000136D6
			// Note: this type is marked as 'beforefieldinit'.
			static IMGUISendQueuedEvents()
			{
				Il2CppClassPointerStore<PreUpdate.IMGUISendQueuedEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "IMGUISendQueuedEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.IMGUISendQueuedEvents>.NativeClassPtr);
			}

			// Token: 0x06003AA0 RID: 15008 RVA: 0x000154F6 File Offset: 0x000136F6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.IMGUISendQueuedEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D2 RID: 2258
		[StructLayout(2)]
		public struct SendMouseEvents
		{
			// Token: 0x06003AA1 RID: 15009 RVA: 0x00015508 File Offset: 0x00013708
			// Note: this type is marked as 'beforefieldinit'.
			static SendMouseEvents()
			{
				Il2CppClassPointerStore<PreUpdate.SendMouseEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "SendMouseEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.SendMouseEvents>.NativeClassPtr);
			}

			// Token: 0x06003AA2 RID: 15010 RVA: 0x00015528 File Offset: 0x00013728
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.SendMouseEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D3 RID: 2259
		[StructLayout(2)]
		public struct AIUpdate
		{
			// Token: 0x06003AA3 RID: 15011 RVA: 0x0001553A File Offset: 0x0001373A
			// Note: this type is marked as 'beforefieldinit'.
			static AIUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.AIUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "AIUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.AIUpdate>.NativeClassPtr);
			}

			// Token: 0x06003AA4 RID: 15012 RVA: 0x0001555A File Offset: 0x0001375A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.AIUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D4 RID: 2260
		[StructLayout(2)]
		public struct WindUpdate
		{
			// Token: 0x06003AA5 RID: 15013 RVA: 0x0001556C File Offset: 0x0001376C
			// Note: this type is marked as 'beforefieldinit'.
			static WindUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.WindUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "WindUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.WindUpdate>.NativeClassPtr);
			}

			// Token: 0x06003AA6 RID: 15014 RVA: 0x0001558C File Offset: 0x0001378C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.WindUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D5 RID: 2261
		[StructLayout(2)]
		public struct UpdateVideo
		{
			// Token: 0x06003AA7 RID: 15015 RVA: 0x0001559E File Offset: 0x0001379E
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateVideo()
			{
				Il2CppClassPointerStore<PreUpdate.UpdateVideo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "UpdateVideo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.UpdateVideo>.NativeClassPtr);
			}

			// Token: 0x06003AA8 RID: 15016 RVA: 0x000155BE File Offset: 0x000137BE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.UpdateVideo>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x020008D6 RID: 2262
		[StructLayout(2)]
		public struct NewInputUpdate
		{
			// Token: 0x06003AA9 RID: 15017 RVA: 0x000155D0 File Offset: 0x000137D0
			// Note: this type is marked as 'beforefieldinit'.
			static NewInputUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.NewInputUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "NewInputUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.NewInputUpdate>.NativeClassPtr);
			}

			// Token: 0x06003AAA RID: 15018 RVA: 0x000155F0 File Offset: 0x000137F0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.NewInputUpdate>.NativeClassPtr, ref this));
			}
		}
	}
}
