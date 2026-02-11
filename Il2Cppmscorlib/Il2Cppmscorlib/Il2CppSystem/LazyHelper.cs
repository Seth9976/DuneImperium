using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x020000BC RID: 188
	public class LazyHelper : Object
	{
		// Token: 0x06000C3E RID: 3134 RVA: 0x0005E7BC File Offset: 0x0005C9BC
		// Note: this type is marked as 'beforefieldinit'.
		static LazyHelper()
		{
			Il2CppClassPointerStore<LazyHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LazyHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr);
			LazyHelper.NativeFieldInfoPtr_NoneViaConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "NoneViaConstructor");
			LazyHelper.NativeFieldInfoPtr_NoneViaFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "NoneViaFactory");
			LazyHelper.NativeFieldInfoPtr_PublicationOnlyViaConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "PublicationOnlyViaConstructor");
			LazyHelper.NativeFieldInfoPtr_PublicationOnlyViaFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "PublicationOnlyViaFactory");
			LazyHelper.NativeFieldInfoPtr_PublicationOnlyWaitForOtherThreadToPublish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "PublicationOnlyWaitForOtherThreadToPublish");
			LazyHelper.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "<State>k__BackingField");
			LazyHelper.NativeFieldInfoPtr__exceptionDispatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, "_exceptionDispatch");
			LazyHelper.NativeMethodInfoPtr_get_State_Internal_get_LazyState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, 100665438);
			LazyHelper.NativeMethodInfoPtr__ctor_Internal_Void_LazyState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, 100665439);
			LazyHelper.NativeMethodInfoPtr__ctor_Internal_Void_LazyThreadSafetyMode_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, 100665440);
			LazyHelper.NativeMethodInfoPtr_ThrowException_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, 100665441);
			LazyHelper.NativeMethodInfoPtr_Create_Internal_Static_LazyHelper_LazyThreadSafetyMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, 100665442);
			LazyHelper.NativeMethodInfoPtr_CreateViaDefaultConstructor_Internal_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr, 100665443);
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0005E8F0 File Offset: 0x0005CAF0
		public unsafe LazyState State
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyHelper.NativeMethodInfoPtr_get_State_Internal_get_LazyState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0005E92C File Offset: 0x0005CB2C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LazyHelper(LazyState state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyHelper.NativeMethodInfoPtr__ctor_Internal_Void_LazyState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0005E974 File Offset: 0x0005CB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1309949, XrefRangeEnd = 1309954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LazyHelper(LazyThreadSafetyMode mode, Exception exception)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyHelper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyHelper.NativeMethodInfoPtr__ctor_Internal_Void_LazyThreadSafetyMode_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0005E9D0 File Offset: 0x0005CBD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1309987, RefRangeEnd = 1309989, XrefRangeStart = 1309954, XrefRangeEnd = 1309987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyHelper.NativeMethodInfoPtr_ThrowException_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0005EA04 File Offset: 0x0005CC04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1309993, RefRangeEnd = 1309998, XrefRangeStart = 1309989, XrefRangeEnd = 1309993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LazyHelper Create(LazyThreadSafetyMode mode, bool useDefaultConstructor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDefaultConstructor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyHelper.NativeMethodInfoPtr_Create_Internal_Static_LazyHelper_LazyThreadSafetyMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr3) : null;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0005EA54 File Offset: 0x0005CC54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1309999, RefRangeEnd = 1310000, XrefRangeStart = 1309998, XrefRangeEnd = 1309999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateViaDefaultConstructor(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyHelper.NativeMethodInfoPtr_CreateViaDefaultConstructor_Internal_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000050A8 File Offset: 0x000032A8
		public LazyHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0005EA98 File Offset: 0x0005CC98
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x000050B1 File Offset: 0x000032B1
		public unsafe static LazyHelper NoneViaConstructor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LazyHelper.NativeFieldInfoPtr_NoneViaConstructor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LazyHelper.NativeFieldInfoPtr_NoneViaConstructor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0005EAC0 File Offset: 0x0005CCC0
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x000050C3 File Offset: 0x000032C3
		public unsafe static LazyHelper NoneViaFactory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LazyHelper.NativeFieldInfoPtr_NoneViaFactory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LazyHelper.NativeFieldInfoPtr_NoneViaFactory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0005EAE8 File Offset: 0x0005CCE8
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x000050D5 File Offset: 0x000032D5
		public unsafe static LazyHelper PublicationOnlyViaConstructor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LazyHelper.NativeFieldInfoPtr_PublicationOnlyViaConstructor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LazyHelper.NativeFieldInfoPtr_PublicationOnlyViaConstructor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0005EB10 File Offset: 0x0005CD10
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x000050E7 File Offset: 0x000032E7
		public unsafe static LazyHelper PublicationOnlyViaFactory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LazyHelper.NativeFieldInfoPtr_PublicationOnlyViaFactory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LazyHelper.NativeFieldInfoPtr_PublicationOnlyViaFactory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0005EB38 File Offset: 0x0005CD38
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x000050F9 File Offset: 0x000032F9
		public unsafe static LazyHelper PublicationOnlyWaitForOtherThreadToPublish
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LazyHelper.NativeFieldInfoPtr_PublicationOnlyWaitForOtherThreadToPublish, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyHelper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LazyHelper.NativeFieldInfoPtr_PublicationOnlyWaitForOtherThreadToPublish, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x0005EB60 File Offset: 0x0005CD60
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x0000510B File Offset: 0x0000330B
		public unsafe LazyState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyHelper.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyHelper.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0005EB88 File Offset: 0x0005CD88
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00005126 File Offset: 0x00003326
		public unsafe ExceptionDispatchInfo _exceptionDispatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyHelper.NativeFieldInfoPtr__exceptionDispatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyHelper.NativeFieldInfoPtr__exceptionDispatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeFieldInfoPtr_NoneViaConstructor;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeFieldInfoPtr_NoneViaFactory;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeFieldInfoPtr_PublicationOnlyViaConstructor;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeFieldInfoPtr_PublicationOnlyViaFactory;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeFieldInfoPtr_PublicationOnlyWaitForOtherThreadToPublish;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeFieldInfoPtr__exceptionDispatch;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Internal_get_LazyState_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LazyState_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LazyThreadSafetyMode_Exception_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_ThrowException_Internal_Void_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_LazyHelper_LazyThreadSafetyMode_Boolean_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_CreateViaDefaultConstructor_Internal_Static_Object_Type_0;
	}
}
