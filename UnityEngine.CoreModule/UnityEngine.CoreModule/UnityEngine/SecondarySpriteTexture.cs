using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000180 RID: 384
	[Serializable]
	public sealed class SecondarySpriteTexture : ValueType
	{
		// Token: 0x06001CCB RID: 7371 RVA: 0x000844EC File Offset: 0x000826EC
		// Note: this type is marked as 'beforefieldinit'.
		static SecondarySpriteTexture()
		{
			Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SecondarySpriteTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr);
			SecondarySpriteTexture.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr, "name");
			SecondarySpriteTexture.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr, "texture");
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0000ACA7 File Offset: 0x00008EA7
		public SecondarySpriteTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		public SecondarySpriteTexture()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr))
		{
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001CCE RID: 7374 RVA: 0x00084544 File Offset: 0x00082744
		// (set) Token: 0x06001CCF RID: 7375 RVA: 0x0000ACC2 File Offset: 0x00008EC2
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecondarySpriteTexture.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecondarySpriteTexture.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x0008456C File Offset: 0x0008276C
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x0000ACE1 File Offset: 0x00008EE1
		public unsafe Texture2D texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecondarySpriteTexture.NativeFieldInfoPtr_texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecondarySpriteTexture.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeFieldInfoPtr_texture;
	}
}
