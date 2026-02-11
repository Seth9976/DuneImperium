using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace canis.archetypes
{
	// Token: 0x02000010 RID: 16
	public static class ArchetypesSingleton : Object
	{
		// Token: 0x0600009D RID: 157 RVA: 0x0001BB30 File Offset: 0x00019D30
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypesSingleton()
		{
			Il2CppClassPointerStore<ArchetypesSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "canis.archetypes", "ArchetypesSingleton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypesSingleton>.NativeClassPtr);
			ArchetypesSingleton.NativeFieldInfoPtr__archetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypesSingleton>.NativeClassPtr, "_archetypes");
			ArchetypesSingleton.NativeMethodInfoPtr_setArchetypes_Public_Static_Void_Archetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesSingleton>.NativeClassPtr, 100663356);
			ArchetypesSingleton.NativeMethodInfoPtr_getArchetypes_Public_Static_Archetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypesSingleton>.NativeClassPtr, 100663357);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0001BB9C File Offset: 0x00019D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543255, XrefRangeEnd = 543259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void setArchetypes(Archetypes archetypes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypesSingleton.NativeMethodInfoPtr_setArchetypes_Public_Static_Void_Archetypes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0001BBD4 File Offset: 0x00019DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 543261, RefRangeEnd = 543262, XrefRangeStart = 543259, XrefRangeEnd = 543261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Archetypes getArchetypes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypesSingleton.NativeMethodInfoPtr_getArchetypes_Public_Static_Archetypes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetypes>(intPtr3) : null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002503 File Offset: 0x00000703
		public ArchetypesSingleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0001BC08 File Offset: 0x00019E08
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000250C File Offset: 0x0000070C
		public unsafe static Archetypes _archetypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArchetypesSingleton.NativeFieldInfoPtr__archetypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Archetypes>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArchetypesSingleton.NativeFieldInfoPtr__archetypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr__archetypes;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_setArchetypes_Public_Static_Void_Archetypes_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_getArchetypes_Public_Static_Archetypes_0;
	}
}
