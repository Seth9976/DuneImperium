using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lib.canis.voodoo.src.voodoo.renderAnimator
{
	// Token: 0x02000011 RID: 17
	public class EntityEventLocator : MonoBehaviour
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0000AA58 File Offset: 0x00008C58
		// Note: this type is marked as 'beforefieldinit'.
		static EntityEventLocator()
		{
			Il2CppClassPointerStore<EntityEventLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.canis.voodoo.src.voodoo.renderAnimator", "EntityEventLocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityEventLocator>.NativeClassPtr);
			EntityEventLocator.NativeFieldInfoPtr_eventTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityEventLocator>.NativeClassPtr, "eventTriggers");
			EntityEventLocator.NativeMethodInfoPtr_InvokeEvent_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityEventLocator>.NativeClassPtr, 100663359);
			EntityEventLocator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityEventLocator>.NativeClassPtr, 100663360);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000AAC4 File Offset: 0x00008CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106804, XrefRangeEnd = 1106807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InvokeEvent(string triggerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(triggerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityEventLocator.NativeMethodInfoPtr_InvokeEvent_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000AB08 File Offset: 0x00008D08
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityEventLocator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityEventLocator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityEventLocator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002573 File Offset: 0x00000773
		public EntityEventLocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000AB44 File Offset: 0x00008D44
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000257C File Offset: 0x0000077C
		public unsafe Il2CppReferenceArray<EventTrigger> eventTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityEventLocator.NativeFieldInfoPtr_eventTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventTrigger>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityEventLocator.NativeFieldInfoPtr_eventTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_eventTriggers;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_InvokeEvent_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
