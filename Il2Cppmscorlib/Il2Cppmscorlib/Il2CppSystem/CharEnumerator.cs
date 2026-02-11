using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000082 RID: 130
	[Serializable]
	public sealed class CharEnumerator : Object
	{
		// Token: 0x0600078E RID: 1934 RVA: 0x00047BB0 File Offset: 0x00045DB0
		// Note: this type is marked as 'beforefieldinit'.
		static CharEnumerator()
		{
			Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CharEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr);
			CharEnumerator.NativeFieldInfoPtr__str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, "_str");
			CharEnumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, "_index");
			CharEnumerator.NativeFieldInfoPtr__currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, "_currentElement");
			CharEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664572);
			CharEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664573);
			CharEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664574);
			CharEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664575);
			CharEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664576);
			CharEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664577);
			CharEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664578);
			CharEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664579);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00047CBC File Offset: 0x00045EBC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 437321, RefRangeEnd = 437325, XrefRangeStart = 437321, XrefRangeEnd = 437325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharEnumerator(string str)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00047D08 File Offset: 0x00045F08
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00047D48 File Offset: 0x00045F48
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00047D84 File Offset: 0x00045F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300223, XrefRangeEnd = 1300224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00047DB8 File Offset: 0x00045FB8
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300224, XrefRangeEnd = 1300227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00047DF8 File Offset: 0x00045FF8
		public unsafe char Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00047E34 File Offset: 0x00046034
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00047E68 File Offset: 0x00046068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300227, XrefRangeEnd = 1300230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharEnumerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000042BB File Offset: 0x000024BB
		public CharEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00047EA4 File Offset: 0x000460A4
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x000042C4 File Offset: 0x000024C4
		public unsafe string _str
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEnumerator.NativeFieldInfoPtr__str);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEnumerator.NativeFieldInfoPtr__str), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00047ECC File Offset: 0x000460CC
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x000042E3 File Offset: 0x000024E3
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEnumerator.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEnumerator.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00047EF4 File Offset: 0x000460F4
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x000042FE File Offset: 0x000024FE
		public unsafe char _currentElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEnumerator.NativeFieldInfoPtr__currentElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEnumerator.NativeFieldInfoPtr__currentElement)) = value;
			}
		}

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr__str;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeFieldInfoPtr__currentElement;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Char_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
