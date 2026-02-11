using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace core.ui
{
	// Token: 0x02000007 RID: 7
	public class TMPResetCaret : MonoBehaviour
	{
		// Token: 0x06000024 RID: 36 RVA: 0x0000327C File Offset: 0x0000147C
		// Note: this type is marked as 'beforefieldinit'.
		static TMPResetCaret()
		{
			Il2CppClassPointerStore<TMPResetCaret>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "core.ui", "TMPResetCaret");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPResetCaret>.NativeClassPtr);
			TMPResetCaret.NativeFieldInfoPtr_caretName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPResetCaret>.NativeClassPtr, "caretName");
			TMPResetCaret.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPResetCaret>.NativeClassPtr, "inputField");
			TMPResetCaret.NativeFieldInfoPtr_inputCaretTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPResetCaret>.NativeClassPtr, "inputCaretTransform");
			TMPResetCaret.NativeFieldInfoPtr_inputFieldTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPResetCaret>.NativeClassPtr, "inputFieldTransform");
			TMPResetCaret.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPResetCaret>.NativeClassPtr, 100663312);
			TMPResetCaret.NativeMethodInfoPtr_OnInputChanged_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPResetCaret>.NativeClassPtr, 100663313);
			TMPResetCaret.NativeMethodInfoPtr_SetupCaret_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPResetCaret>.NativeClassPtr, 100663314);
			TMPResetCaret.NativeMethodInfoPtr_ResetCaretPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPResetCaret>.NativeClassPtr, 100663315);
			TMPResetCaret.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPResetCaret>.NativeClassPtr, 100663316);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003360 File Offset: 0x00001560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253458, XrefRangeEnd = 1253472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPResetCaret.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003394 File Offset: 0x00001594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253472, XrefRangeEnd = 1253493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputChanged(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPResetCaret.NativeMethodInfoPtr_OnInputChanged_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000033D8 File Offset: 0x000015D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1253509, RefRangeEnd = 1253510, XrefRangeStart = 1253493, XrefRangeEnd = 1253509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupCaret()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPResetCaret.NativeMethodInfoPtr_SetupCaret_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000340C File Offset: 0x0000160C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253510, XrefRangeEnd = 1253523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCaretPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPResetCaret.NativeMethodInfoPtr_ResetCaretPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003440 File Offset: 0x00001640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253523, XrefRangeEnd = 1253528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMPResetCaret()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMPResetCaret>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPResetCaret.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002149 File Offset: 0x00000349
		public TMPResetCaret(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000347C File Offset: 0x0000167C
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002152 File Offset: 0x00000352
		public unsafe string caretName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPResetCaret.NativeFieldInfoPtr_caretName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPResetCaret.NativeFieldInfoPtr_caretName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000034A4 File Offset: 0x000016A4
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002171 File Offset: 0x00000371
		public unsafe TMP_InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPResetCaret.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPResetCaret.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000034D4 File Offset: 0x000016D4
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002190 File Offset: 0x00000390
		public unsafe RectTransform inputCaretTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPResetCaret.NativeFieldInfoPtr_inputCaretTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPResetCaret.NativeFieldInfoPtr_inputCaretTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00003504 File Offset: 0x00001704
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000021AF File Offset: 0x000003AF
		public unsafe RectTransform inputFieldTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPResetCaret.NativeFieldInfoPtr_inputFieldTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMPResetCaret.NativeFieldInfoPtr_inputFieldTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_caretName;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_inputCaretTransform;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_inputFieldTransform;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_OnInputChanged_Public_Void_String_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_SetupCaret_Private_Void_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_ResetCaretPosition_Private_Void_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
