using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000115 RID: 277
	public static class PointerEventHelper : Object
	{
		// Token: 0x06001526 RID: 5414 RVA: 0x00009EE6 File Offset: 0x000080E6
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEventHelper()
		{
			Il2CppClassPointerStore<PointerEventHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerEventHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEventHelper>.NativeClassPtr);
			PointerEventHelper.NativeMethodInfoPtr_GetPooled_Public_Static_EventBase_EventType_Vector3_Vector2_Int32_Int32_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventHelper>.NativeClassPtr, 100666402);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00067E48 File Offset: 0x00066048
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315961, RefRangeEnd = 315963, XrefRangeStart = 315939, XrefRangeEnd = 315961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventBase GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mousePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delta;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref button;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clickCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventHelper.NativeMethodInfoPtr_GetPooled_Public_Static_EventBase_EventType_Vector3_Vector2_Int32_Int32_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00009F1F File Offset: 0x0000811F
		public PointerEventHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_EventBase_EventType_Vector3_Vector2_Int32_Int32_EventModifiers_0;
	}
}
