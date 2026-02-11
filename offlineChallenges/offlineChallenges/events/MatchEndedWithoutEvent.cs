using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace offlineChallenges.events
{
	// Token: 0x02000010 RID: 16
	public class MatchEndedWithoutEvent<T> : OfflineChallenges.ComplexEvent where T : OfflineChallenges.Event
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00005208 File Offset: 0x00003408
		// Note: this type is marked as 'beforefieldinit'.
		static MatchEndedWithoutEvent()
		{
			Il2CppClassPointerStore<MatchEndedWithoutEvent<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges.events", "MatchEndedWithoutEvent`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchEndedWithoutEvent<T>>.NativeClassPtr);
			MatchEndedWithoutEvent<T>.NativeFieldInfoPtr_failed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchEndedWithoutEvent<T>>.NativeClassPtr, "failed");
			MatchEndedWithoutEvent<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEndedWithoutEvent<T>>.NativeClassPtr, 100663411);
			MatchEndedWithoutEvent<T>.NativeMethodInfoPtr_Process_Public_Virtual_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEndedWithoutEvent<T>>.NativeClassPtr, 100663412);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000052B0 File Offset: 0x000034B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261176, XrefRangeEnd = 1261177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchEndedWithoutEvent(int id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchEndedWithoutEvent<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEndedWithoutEvent<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000052F8 File Offset: 0x000034F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261177, XrefRangeEnd = 1261182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Process(OfflineChallenges.Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchEndedWithoutEvent<T>.NativeMethodInfoPtr_Process_Public_Virtual_Void_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000251A File Offset: 0x0000071A
		public MatchEndedWithoutEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00005348 File Offset: 0x00003548
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002523 File Offset: 0x00000723
		public unsafe bool failed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchEndedWithoutEvent<T>.NativeFieldInfoPtr_failed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchEndedWithoutEvent<T>.NativeFieldInfoPtr_failed)) = value;
			}
		}

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_failed;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_Event_0;
	}
}
