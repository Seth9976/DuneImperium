using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace offlineChallenges.events
{
	// Token: 0x02000011 RID: 17
	public class NEventsInOneGameEvent<T> : OfflineChallenges.ComplexEvent where T : OfflineChallenges.Event
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00005370 File Offset: 0x00003570
		// Note: this type is marked as 'beforefieldinit'.
		static NEventsInOneGameEvent()
		{
			Il2CppClassPointerStore<NEventsInOneGameEvent<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("offlineChallenges.dll", "offlineChallenges.events", "NEventsInOneGameEvent`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NEventsInOneGameEvent<T>>.NativeClassPtr);
			NEventsInOneGameEvent<T>.NativeFieldInfoPtr_numberLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NEventsInOneGameEvent<T>>.NativeClassPtr, "numberLeft");
			NEventsInOneGameEvent<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NEventsInOneGameEvent<T>>.NativeClassPtr, 100663413);
			NEventsInOneGameEvent<T>.NativeMethodInfoPtr_Process_Public_Virtual_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NEventsInOneGameEvent<T>>.NativeClassPtr, 100663414);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005418 File Offset: 0x00003618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261182, XrefRangeEnd = 1261183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NEventsInOneGameEvent(int id, int number)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NEventsInOneGameEvent<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NEventsInOneGameEvent<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005470 File Offset: 0x00003670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261183, XrefRangeEnd = 1261188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Process(OfflineChallenges.Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NEventsInOneGameEvent<T>.NativeMethodInfoPtr_Process_Public_Virtual_Void_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000253E File Offset: 0x0000073E
		public NEventsInOneGameEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000054C0 File Offset: 0x000036C0
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002547 File Offset: 0x00000747
		public unsafe int numberLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NEventsInOneGameEvent<T>.NativeFieldInfoPtr_numberLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NEventsInOneGameEvent<T>.NativeFieldInfoPtr_numberLeft)) = value;
			}
		}

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_numberLeft;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_Event_0;
	}
}
