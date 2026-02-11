using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200024F RID: 591
	public sealed class State : ValueType
	{
		// Token: 0x06002BC9 RID: 11209 RVA: 0x000BD458 File Offset: 0x000BB658
		// Note: this type is marked as 'beforefieldinit'.
		static State()
		{
			Il2CppClassPointerStore<State>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "State");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<State>.NativeClassPtr);
			State.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "material");
			State.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "texture");
			State.NativeFieldInfoPtr_stencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "stencilRef");
			State.NativeFieldInfoPtr_sdfScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "sdfScale");
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x00011B75 File Offset: 0x0000FD75
		public State(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00011B7E File Offset: 0x0000FD7E
		public State()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<State>.NativeClassPtr))
		{
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x000BD4D8 File Offset: 0x000BB6D8
		// (set) Token: 0x06002BCD RID: 11213 RVA: 0x00011B90 File Offset: 0x0000FD90
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x000BD508 File Offset: 0x000BB708
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x00011BAF File Offset: 0x0000FDAF
		public unsafe TextureId texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_texture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_texture)) = value;
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x000BD530 File Offset: 0x000BB730
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x00011BCA File Offset: 0x0000FDCA
		public unsafe int stencilRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_stencilRef);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_stencilRef)) = value;
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x000BD558 File Offset: 0x000BB758
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x00011BE5 File Offset: 0x0000FDE5
		public unsafe float sdfScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_sdfScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_sdfScale)) = value;
			}
		}

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeFieldInfoPtr_texture;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeFieldInfoPtr_stencilRef;

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeFieldInfoPtr_sdfScale;
	}
}
