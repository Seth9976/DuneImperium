using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020000B6 RID: 182
	public sealed class OidEnumerator : Object
	{
		// Token: 0x06000CD5 RID: 3285 RVA: 0x0004BE24 File Offset: 0x0004A024
		// Note: this type is marked as 'beforefieldinit'.
		static OidEnumerator()
		{
			Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography", "OidEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr);
			OidEnumerator.NativeFieldInfoPtr__oids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, "_oids");
			OidEnumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, "_current");
			OidEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_OidCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100665137);
			OidEnumerator.NativeMethodInfoPtr_get_Current_Public_get_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100665138);
			OidEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100665139);
			OidEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100665140);
			OidEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr, 100665141);
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0004BEE0 File Offset: 0x0004A0E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 437321, RefRangeEnd = 437325, XrefRangeStart = 437321, XrefRangeEnd = 437325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OidEnumerator(OidCollection oids)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OidEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oids);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_OidCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x0004BF2C File Offset: 0x0004A12C
		public unsafe Oid Current
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 452449, RefRangeEnd = 452450, XrefRangeStart = 452445, XrefRangeEnd = 452449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr_get_Current_Public_get_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr3) : null;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0004BF6C File Offset: 0x0004A16C
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 452449, RefRangeEnd = 452450, XrefRangeStart = 452449, XrefRangeEnd = 452450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0004BFAC File Offset: 0x0004A1AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452451, RefRangeEnd = 452452, XrefRangeStart = 452450, XrefRangeEnd = 452451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0004BFE8 File Offset: 0x0004A1E8
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OidEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00006C30 File Offset: 0x00004E30
		public OidEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0004C01C File Offset: 0x0004A21C
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00006C39 File Offset: 0x00004E39
		public unsafe OidCollection _oids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidEnumerator.NativeFieldInfoPtr__oids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OidCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidEnumerator.NativeFieldInfoPtr__oids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0004C04C File Offset: 0x0004A24C
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00006C58 File Offset: 0x00004E58
		public unsafe int _current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidEnumerator.NativeFieldInfoPtr__current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OidEnumerator.NativeFieldInfoPtr__current)) = value;
			}
		}

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeFieldInfoPtr__oids;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeFieldInfoPtr__current;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_OidCollection_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_Oid_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
