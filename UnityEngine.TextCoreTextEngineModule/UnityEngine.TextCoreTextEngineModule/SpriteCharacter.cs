using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	public class SpriteCharacter : TextElement
	{
		// Token: 0x06000208 RID: 520 RVA: 0x0000D61C File Offset: 0x0000B81C
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteCharacter()
		{
			Il2CppClassPointerStore<SpriteCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "SpriteCharacter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteCharacter>.NativeClassPtr);
			SpriteCharacter.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteCharacter>.NativeClassPtr, "m_Name");
			SpriteCharacter.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteCharacter>.NativeClassPtr, 100663508);
			SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteCharacter>.NativeClassPtr, 100663509);
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000D688 File Offset: 0x0000B888
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0000D724 File Offset: 0x0000B924
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteCharacter.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				bool flag = value == this.m_Name;
				if (!flag)
				{
					this.m_Name = value;
				}
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000D6C0 File Offset: 0x0000B8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteCharacter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteCharacter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000302B File Offset: 0x0000122B
		public SpriteCharacter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0000D6FC File Offset: 0x0000B8FC
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00003034 File Offset: 0x00001234
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteCharacter.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteCharacter.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
