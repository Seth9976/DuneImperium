using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace lotus
{
	// Token: 0x020000D0 RID: 208
	public class SingleLineTextHack : MonoBehaviour
	{
		// Token: 0x06000A09 RID: 2569 RVA: 0x00031180 File Offset: 0x0002F380
		// Note: this type is marked as 'beforefieldinit'.
		static SingleLineTextHack()
		{
			Il2CppClassPointerStore<SingleLineTextHack>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "SingleLineTextHack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleLineTextHack>.NativeClassPtr);
			SingleLineTextHack.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleLineTextHack>.NativeClassPtr, "inputField");
			SingleLineTextHack.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleLineTextHack>.NativeClassPtr, 100664925);
			SingleLineTextHack.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleLineTextHack>.NativeClassPtr, 100664926);
			SingleLineTextHack.NativeMethodInfoPtr_UpdateHack_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleLineTextHack>.NativeClassPtr, 100664927);
			SingleLineTextHack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleLineTextHack>.NativeClassPtr, 100664928);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00031214 File Offset: 0x0002F414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993486, XrefRangeEnd = 993500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleLineTextHack.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00031248 File Offset: 0x0002F448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993500, XrefRangeEnd = 993513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleLineTextHack.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0003127C File Offset: 0x0002F47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993513, XrefRangeEnd = 993516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHack(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleLineTextHack.NativeMethodInfoPtr_UpdateHack_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x000312C0 File Offset: 0x0002F4C0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleLineTextHack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleLineTextHack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleLineTextHack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x000068C9 File Offset: 0x00004AC9
		public SingleLineTextHack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x000312FC File Offset: 0x0002F4FC
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x000068D2 File Offset: 0x00004AD2
		public unsafe InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleLineTextHack.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleLineTextHack.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHack_Private_Void_String_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
