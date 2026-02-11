using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000224 RID: 548
	public static class EventInterestReflectionUtils : Object
	{
		// Token: 0x06002924 RID: 10532 RVA: 0x000B4348 File Offset: 0x000B2548
		// Note: this type is marked as 'beforefieldinit'.
		static EventInterestReflectionUtils()
		{
			Il2CppClassPointerStore<EventInterestReflectionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventInterestReflectionUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventInterestReflectionUtils>.NativeClassPtr);
			EventInterestReflectionUtils.NativeFieldInfoPtr_s_DefaultEventInterests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterestReflectionUtils>.NativeClassPtr, "s_DefaultEventInterests");
			EventInterestReflectionUtils.NativeFieldInfoPtr_s_EventCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterestReflectionUtils>.NativeClassPtr, "s_EventCategories");
			EventInterestReflectionUtils.NativeMethodInfoPtr_GetDefaultEventInterests_Internal_Static_Void_Type_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterestReflectionUtils>.NativeClassPtr, 100669483);
			EventInterestReflectionUtils.NativeMethodInfoPtr_ComputeDefaultEventInterests_Private_Static_Int32_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterestReflectionUtils>.NativeClassPtr, 100669484);
			EventInterestReflectionUtils.NativeMethodInfoPtr_GetEventCategory_Internal_Static_EventCategory_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterestReflectionUtils>.NativeClassPtr, 100669485);
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000B43DC File Offset: 0x000B25DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346285, RefRangeEnd = 346287, XrefRangeStart = 346253, XrefRangeEnd = 346285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDefaultEventInterests(Type elementType, out int defaultActionCategories, out int defaultActionAtTargetCategories)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &defaultActionCategories;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &defaultActionAtTargetCategories;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterestReflectionUtils.NativeMethodInfoPtr_GetDefaultEventInterests_Internal_Static_Void_Type_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x000B4430 File Offset: 0x000B2630
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 346303, RefRangeEnd = 346307, XrefRangeStart = 346287, XrefRangeEnd = 346303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ComputeDefaultEventInterests(Type elementType, string methodName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterestReflectionUtils.NativeMethodInfoPtr_ComputeDefaultEventInterests_Private_Static_Int32_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000B4484 File Offset: 0x000B2684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346328, RefRangeEnd = 346329, XrefRangeStart = 346307, XrefRangeEnd = 346328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventCategory GetEventCategory(Type eventType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterestReflectionUtils.NativeMethodInfoPtr_GetEventCategory_Internal_Static_EventCategory_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x0001096C File Offset: 0x0000EB6C
		public EventInterestReflectionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x000B44C8 File Offset: 0x000B26C8
		// (set) Token: 0x0600292A RID: 10538 RVA: 0x00010975 File Offset: 0x0000EB75
		public unsafe static Dictionary<Type, EventInterestReflectionUtils.DefaultEventInterests> s_DefaultEventInterests
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventInterestReflectionUtils.NativeFieldInfoPtr_s_DefaultEventInterests, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, EventInterestReflectionUtils.DefaultEventInterests>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventInterestReflectionUtils.NativeFieldInfoPtr_s_DefaultEventInterests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x000B44F0 File Offset: 0x000B26F0
		// (set) Token: 0x0600292C RID: 10540 RVA: 0x00010987 File Offset: 0x0000EB87
		public unsafe static Dictionary<Type, EventCategory> s_EventCategories
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventInterestReflectionUtils.NativeFieldInfoPtr_s_EventCategories, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, EventCategory>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventInterestReflectionUtils.NativeFieldInfoPtr_s_EventCategories, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultEventInterests;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeFieldInfoPtr_s_EventCategories;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultEventInterests_Internal_Static_Void_Type_byref_Int32_byref_Int32_0;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr_ComputeDefaultEventInterests_Private_Static_Int32_Type_String_0;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeMethodInfoPtr_GetEventCategory_Internal_Static_EventCategory_Type_0;

		// Token: 0x0200052D RID: 1325
		[StructLayout(2)]
		public struct DefaultEventInterests
		{
			// Token: 0x0600408E RID: 16526 RVA: 0x00100068 File Offset: 0x000FE268
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultEventInterests()
			{
				Il2CppClassPointerStore<EventInterestReflectionUtils.DefaultEventInterests>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventInterestReflectionUtils>.NativeClassPtr, "DefaultEventInterests");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventInterestReflectionUtils.DefaultEventInterests>.NativeClassPtr);
				EventInterestReflectionUtils.DefaultEventInterests.NativeFieldInfoPtr_DefaultActionCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterestReflectionUtils.DefaultEventInterests>.NativeClassPtr, "DefaultActionCategories");
				EventInterestReflectionUtils.DefaultEventInterests.NativeFieldInfoPtr_DefaultActionAtTargetCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterestReflectionUtils.DefaultEventInterests>.NativeClassPtr, "DefaultActionAtTargetCategories");
			}

			// Token: 0x0600408F RID: 16527 RVA: 0x0001B2DD File Offset: 0x000194DD
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventInterestReflectionUtils.DefaultEventInterests>.NativeClassPtr, ref this));
			}

			// Token: 0x04002D6E RID: 11630
			private static readonly IntPtr NativeFieldInfoPtr_DefaultActionCategories;

			// Token: 0x04002D6F RID: 11631
			private static readonly IntPtr NativeFieldInfoPtr_DefaultActionAtTargetCategories;

			// Token: 0x04002D70 RID: 11632
			[FieldOffset(0)]
			public int DefaultActionCategories;

			// Token: 0x04002D71 RID: 11633
			[FieldOffset(4)]
			public int DefaultActionAtTargetCategories;
		}
	}
}
