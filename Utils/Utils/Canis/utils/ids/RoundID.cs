using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.ids
{
	// Token: 0x0200001F RID: 31
	public class RoundID : TypedID
	{
		// Token: 0x06000138 RID: 312 RVA: 0x000094FC File Offset: 0x000076FC
		// Note: this type is marked as 'beforefieldinit'.
		static RoundID()
		{
			Il2CppClassPointerStore<RoundID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.ids", "RoundID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundID>.NativeClassPtr);
			RoundID.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundID>.NativeClassPtr, "Empty");
			RoundID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundID>.NativeClassPtr, 100663494);
			RoundID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundID>.NativeClassPtr, 100663495);
			RoundID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundID>.NativeClassPtr, 100663496);
			RoundID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundID>.NativeClassPtr, 100663497);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00009590 File Offset: 0x00007790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179981, XrefRangeEnd = 1179986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000095DC File Offset: 0x000077DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179986, XrefRangeEnd = 1179990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00009624 File Offset: 0x00007824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179990, XrefRangeEnd = 1179995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00009660 File Offset: 0x00007860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179995, XrefRangeEnd = 1180003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002595 File Offset: 0x00000795
		public RoundID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000096A4 File Offset: 0x000078A4
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0000259E File Offset: 0x0000079E
		public unsafe static RoundID Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RoundID.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RoundID.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
