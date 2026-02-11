using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000078 RID: 120
	public class ErrorContext : Object
	{
		// Token: 0x06000A2A RID: 2602 RVA: 0x000418E4 File Offset: 0x0003FAE4
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorContext()
		{
			Il2CppClassPointerStore<ErrorContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "ErrorContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr);
			ErrorContext.NativeFieldInfoPtr__Traced_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, "<Traced>k__BackingField");
			ErrorContext.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, "<Error>k__BackingField");
			ErrorContext.NativeFieldInfoPtr__OriginalObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, "<OriginalObject>k__BackingField");
			ErrorContext.NativeFieldInfoPtr__Member_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, "<Member>k__BackingField");
			ErrorContext.NativeFieldInfoPtr__Path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, "<Path>k__BackingField");
			ErrorContext.NativeFieldInfoPtr__Handled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, "<Handled>k__BackingField");
			ErrorContext.NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, 100665267);
			ErrorContext.NativeMethodInfoPtr_get_Traced_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, 100665268);
			ErrorContext.NativeMethodInfoPtr_set_Traced_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, 100665269);
			ErrorContext.NativeMethodInfoPtr_get_Error_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, 100665270);
			ErrorContext.NativeMethodInfoPtr_get_OriginalObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, 100665271);
			ErrorContext.NativeMethodInfoPtr_get_Member_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, 100665272);
			ErrorContext.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, 100665273);
			ErrorContext.NativeMethodInfoPtr_get_Handled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, 100665274);
			ErrorContext.NativeMethodInfoPtr_set_Handled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr, 100665275);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00041A40 File Offset: 0x0003FC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748816, XrefRangeEnd = 748821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorContext(Object originalObject, Object member, string path, Exception error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorContext.NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00041AC4 File Offset: 0x0003FCC4
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00041B00 File Offset: 0x0003FD00
		public unsafe bool Traced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorContext.NativeMethodInfoPtr_get_Traced_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorContext.NativeMethodInfoPtr_set_Traced_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00041B40 File Offset: 0x0003FD40
		public unsafe Exception Error
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorContext.NativeMethodInfoPtr_get_Error_Public_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00041B80 File Offset: 0x0003FD80
		public unsafe Object OriginalObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorContext.NativeMethodInfoPtr_get_OriginalObject_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00041BC0 File Offset: 0x0003FDC0
		public unsafe Object Member
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorContext.NativeMethodInfoPtr_get_Member_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00041C00 File Offset: 0x0003FE00
		public unsafe string Path
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorContext.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00041C38 File Offset: 0x0003FE38
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00041C74 File Offset: 0x0003FE74
		public unsafe bool Handled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorContext.NativeMethodInfoPtr_get_Handled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorContext.NativeMethodInfoPtr_set_Handled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00005124 File Offset: 0x00003324
		public ErrorContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00041CB4 File Offset: 0x0003FEB4
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x0000512D File Offset: 0x0000332D
		public unsafe bool _Traced_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorContext.NativeFieldInfoPtr__Traced_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorContext.NativeFieldInfoPtr__Traced_k__BackingField)) = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00041CDC File Offset: 0x0003FEDC
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00005148 File Offset: 0x00003348
		public unsafe Exception _Error_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorContext.NativeFieldInfoPtr__Error_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorContext.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00041D0C File Offset: 0x0003FF0C
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00005167 File Offset: 0x00003367
		public unsafe Object _OriginalObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorContext.NativeFieldInfoPtr__OriginalObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorContext.NativeFieldInfoPtr__OriginalObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00041D3C File Offset: 0x0003FF3C
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00005186 File Offset: 0x00003386
		public unsafe Object _Member_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorContext.NativeFieldInfoPtr__Member_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorContext.NativeFieldInfoPtr__Member_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00041D6C File Offset: 0x0003FF6C
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x000051A5 File Offset: 0x000033A5
		public unsafe string _Path_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorContext.NativeFieldInfoPtr__Path_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorContext.NativeFieldInfoPtr__Path_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00041D94 File Offset: 0x0003FF94
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x000051C4 File Offset: 0x000033C4
		public unsafe bool _Handled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorContext.NativeFieldInfoPtr__Handled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorContext.NativeFieldInfoPtr__Handled_k__BackingField)) = value;
			}
		}

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeFieldInfoPtr__Traced_k__BackingField;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeFieldInfoPtr__OriginalObject_k__BackingField;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeFieldInfoPtr__Member_k__BackingField;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeFieldInfoPtr__Path_k__BackingField;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeFieldInfoPtr__Handled_k__BackingField;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_String_Exception_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_get_Traced_Internal_get_Boolean_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_set_Traced_Internal_set_Void_Boolean_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_Exception_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalObject_Public_get_Object_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_get_Member_Public_get_Object_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_get_Handled_Public_get_Boolean_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_set_Handled_Public_set_Void_Boolean_0;
	}
}
