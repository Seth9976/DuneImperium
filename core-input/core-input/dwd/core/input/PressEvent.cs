using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.input
{
	// Token: 0x0200003E RID: 62
	public class PressEvent : DWDEvent
	{
		// Token: 0x060001DB RID: 475 RVA: 0x0000CB80 File Offset: 0x0000AD80
		// Note: this type is marked as 'beforefieldinit'.
		static PressEvent()
		{
			Il2CppClassPointerStore<PressEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "PressEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressEvent>.NativeClassPtr);
			PressEvent.NativeFieldInfoPtr__Press_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressEvent>.NativeClassPtr, "<Press>k__BackingField");
			PressEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressEvent>.NativeClassPtr, 100663547);
			PressEvent.NativeMethodInfoPtr_get_Press_Public_get_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressEvent>.NativeClassPtr, 100663548);
			PressEvent.NativeMethodInfoPtr_set_Press_Private_set_Void_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressEvent>.NativeClassPtr, 100663549);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000CC00 File Offset: 0x0000AE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PressEvent(Press press)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000CC4C File Offset: 0x0000AE4C
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		public unsafe Press Press
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressEvent.NativeMethodInfoPtr_get_Press_Public_get_Press_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Press>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressEvent.NativeMethodInfoPtr_set_Press_Private_set_Void_Press_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00003196 File Offset: 0x00001396
		public PressEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000CCD0 File Offset: 0x0000AED0
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0000319F File Offset: 0x0000139F
		public unsafe Press _Press_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressEvent.NativeFieldInfoPtr__Press_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Press>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressEvent.NativeFieldInfoPtr__Press_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr__Press_k__BackingField;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_get_Press_Public_get_Press_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_set_Press_Private_set_Void_Press_0;
	}
}
