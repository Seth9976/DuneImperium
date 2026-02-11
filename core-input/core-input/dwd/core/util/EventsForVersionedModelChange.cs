using System;
using Canis.utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace dwd.core.util
{
	// Token: 0x02000034 RID: 52
	public class EventsForVersionedModelChange<T> : MonoBehaviour where T : class
	{
		// Token: 0x0600018A RID: 394 RVA: 0x0000BD64 File Offset: 0x00009F64
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForVersionedModelChange()
		{
			Il2CppClassPointerStore<EventsForVersionedModelChange<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.util", "EventsForVersionedModelChange`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForVersionedModelChange<T>>.NativeClassPtr);
			EventsForVersionedModelChange<T>.NativeFieldInfoPtr_onVersionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForVersionedModelChange<T>>.NativeClassPtr, "onVersionChanged");
			EventsForVersionedModelChange<T>.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForVersionedModelChange<T>>.NativeClassPtr, "cachedVersion");
			EventsForVersionedModelChange<T>.NativeMethodInfoPtr_get_Model_Public_Abstract_Virtual_New_get_IVersionedModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForVersionedModelChange<T>>.NativeClassPtr, 100663507);
			EventsForVersionedModelChange<T>.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForVersionedModelChange<T>>.NativeClassPtr, 100663508);
			EventsForVersionedModelChange<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForVersionedModelChange<T>>.NativeClassPtr, 100663509);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000BE34 File Offset: 0x0000A034
		public unsafe virtual IVersionedModel Model
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForVersionedModelChange<T>.NativeMethodInfoPtr_get_Model_Public_Abstract_Virtual_New_get_IVersionedModel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVersionedModel>(intPtr3) : null;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000BE80 File Offset: 0x0000A080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120140, XrefRangeEnd = 1120146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForVersionedModelChange<T>.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1120152, RefRangeEnd = 1120153, XrefRangeStart = 1120146, XrefRangeEnd = 1120152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForVersionedModelChange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForVersionedModelChange<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForVersionedModelChange<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002E6F File Offset: 0x0000106F
		public EventsForVersionedModelChange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002E78 File Offset: 0x00001078
		public unsafe UnityEvent onVersionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForVersionedModelChange<T>.NativeFieldInfoPtr_onVersionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForVersionedModelChange<T>.NativeFieldInfoPtr_onVersionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000BF20 File Offset: 0x0000A120
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002E97 File Offset: 0x00001097
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForVersionedModelChange<T>.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForVersionedModelChange<T>.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_onVersionChanged;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_get_Model_Public_Abstract_Virtual_New_get_IVersionedModel_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
