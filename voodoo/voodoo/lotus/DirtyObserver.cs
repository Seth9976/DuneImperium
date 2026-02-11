using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x02000081 RID: 129
	public sealed class DirtyObserver : ValueType
	{
		// Token: 0x060007A6 RID: 1958 RVA: 0x00022CA0 File Offset: 0x00020EA0
		// Note: this type is marked as 'beforefieldinit'.
		static DirtyObserver()
		{
			Il2CppClassPointerStore<DirtyObserver>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "DirtyObserver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirtyObserver>.NativeClassPtr);
			DirtyObserver.NativeFieldInfoPtr_observer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyObserver>.NativeClassPtr, "observer");
			DirtyObserver.NativeFieldInfoPtr_chainObserver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyObserver>.NativeClassPtr, "chainObserver");
			DirtyObserver.NativeMethodInfoPtr__ctor_Public_Void_Object_IAmDirty_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyObserver>.NativeClassPtr, 100664335);
			DirtyObserver.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyObserver>.NativeClassPtr, 100664336);
			DirtyObserver.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyObserver>.NativeClassPtr, 100664337);
			DirtyObserver.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyObserver>.NativeClassPtr, 100664338);
			DirtyObserver.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DirtyObserver_DirtyObserver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyObserver>.NativeClassPtr, 100664339);
			DirtyObserver.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DirtyObserver_DirtyObserver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyObserver>.NativeClassPtr, 100664340);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00022D70 File Offset: 0x00020F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114859, XrefRangeEnd = 1114860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirtyObserver(Object obj, IAmDirty o, bool chainObserver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirtyObserver>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chainObserver;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirtyObserver.NativeMethodInfoPtr__ctor_Public_Void_Object_IAmDirty_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00022DE0 File Offset: 0x00020FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114860, XrefRangeEnd = 1114862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirtyObserver.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00022E1C File Offset: 0x0002101C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirtyObserver.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00022E60 File Offset: 0x00021060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114862, XrefRangeEnd = 1114865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirtyObserver.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00022EB4 File Offset: 0x000210B4
		[CallerCount(0)]
		public unsafe static bool operator ==(DirtyObserver x, DirtyObserver y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirtyObserver.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DirtyObserver_DirtyObserver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00022F14 File Offset: 0x00021114
		[CallerCount(0)]
		public unsafe static bool operator !=(DirtyObserver x, DirtyObserver y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirtyObserver.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DirtyObserver_DirtyObserver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00005C7E File Offset: 0x00003E7E
		public DirtyObserver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00005C87 File Offset: 0x00003E87
		public DirtyObserver()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirtyObserver>.NativeClassPtr))
		{
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00022F74 File Offset: 0x00021174
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00005C99 File Offset: 0x00003E99
		public unsafe IAmDirty observer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtyObserver.NativeFieldInfoPtr_observer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAmDirty>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtyObserver.NativeFieldInfoPtr_observer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00022FA4 File Offset: 0x000211A4
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x00005CB8 File Offset: 0x00003EB8
		public unsafe bool chainObserver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtyObserver.NativeFieldInfoPtr_chainObserver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtyObserver.NativeFieldInfoPtr_chainObserver)) = value;
			}
		}

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_observer;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_chainObserver;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IAmDirty_Boolean_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DirtyObserver_DirtyObserver_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DirtyObserver_DirtyObserver_0;
	}
}
