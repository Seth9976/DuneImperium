using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BC RID: 188
	public sealed class EventDispatcherGate : ValueType
	{
		// Token: 0x0600114F RID: 4431 RVA: 0x00059A08 File Offset: 0x00057C08
		// Note: this type is marked as 'beforefieldinit'.
		static EventDispatcherGate()
		{
			Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDispatcherGate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr);
			EventDispatcherGate.NativeFieldInfoPtr_m_Dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr, "m_Dispatcher");
			EventDispatcherGate.NativeMethodInfoPtr__ctor_Public_Void_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr, 100665746);
			EventDispatcherGate.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr, 100665747);
			EventDispatcherGate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EventDispatcherGate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr, 100665748);
			EventDispatcherGate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr, 100665749);
			EventDispatcherGate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr, 100665750);
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00059AB0 File Offset: 0x00057CB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 311535, RefRangeEnd = 311542, XrefRangeStart = 311534, XrefRangeEnd = 311535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDispatcherGate(EventDispatcher d)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcherGate.NativeMethodInfoPtr__ctor_Public_Void_EventDispatcher_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00059B00 File Offset: 0x00057D00
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 311544, RefRangeEnd = 311558, XrefRangeStart = 311542, XrefRangeEnd = 311544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcherGate.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00059B38 File Offset: 0x00057D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311558, XrefRangeEnd = 311559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(EventDispatcherGate other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcherGate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EventDispatcherGate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00059B90 File Offset: 0x00057D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311559, XrefRangeEnd = 311563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcherGate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00059BE4 File Offset: 0x00057DE4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcherGate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00008B0F File Offset: 0x00006D0F
		public EventDispatcherGate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00008B18 File Offset: 0x00006D18
		public EventDispatcherGate()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr))
		{
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x00059C28 File Offset: 0x00057E28
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x00008B2A File Offset: 0x00006D2A
		public unsafe EventDispatcher m_Dispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcherGate.NativeFieldInfoPtr_m_Dispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcherGate.NativeFieldInfoPtr_m_Dispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00059C58 File Offset: 0x00057E58
		public static bool operator ==(EventDispatcherGate left, EventDispatcherGate right)
		{
			return left.Equals(right);
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00059C74 File Offset: 0x00057E74
		public static bool operator !=(EventDispatcherGate left, EventDispatcherGate right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeFieldInfoPtr_m_Dispatcher;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventDispatcher_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EventDispatcherGate_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
