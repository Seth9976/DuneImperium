using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000C8 RID: 200
	public class ArchetypeAttribute : PropertyAttribute
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x0000673E File Offset: 0x0000493E
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeAttribute()
		{
			Il2CppClassPointerStore<ArchetypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "ArchetypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeAttribute>.NativeClassPtr);
			ArchetypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeAttribute>.NativeClassPtr, 100664906);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0003091C File Offset: 0x0002EB1C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00006777 File Offset: 0x00004977
		public ArchetypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
