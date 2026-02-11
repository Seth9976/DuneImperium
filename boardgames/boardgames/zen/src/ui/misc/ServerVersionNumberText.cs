using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;

namespace zen.src.ui.misc
{
	// Token: 0x0200004D RID: 77
	public class ServerVersionNumberText : MonoBehaviour
	{
		// Token: 0x06000304 RID: 772 RVA: 0x0001AC30 File Offset: 0x00018E30
		// Note: this type is marked as 'beforefieldinit'.
		static ServerVersionNumberText()
		{
			Il2CppClassPointerStore<ServerVersionNumberText>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.ui.misc", "ServerVersionNumberText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerVersionNumberText>.NativeClassPtr);
			ServerVersionNumberText.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVersionNumberText>.NativeClassPtr, "client");
			ServerVersionNumberText.NativeFieldInfoPtr_prefixLocaleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVersionNumberText>.NativeClassPtr, "prefixLocaleKey");
			ServerVersionNumberText.NativeMethodInfoPtr_get_textField_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersionNumberText>.NativeClassPtr, 100663819);
			ServerVersionNumberText.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersionNumberText>.NativeClassPtr, 100663820);
			ServerVersionNumberText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersionNumberText>.NativeClassPtr, 100663821);
			ServerVersionNumberText.NativeMethodInfoPtr__Start_b__4_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVersionNumberText>.NativeClassPtr, 100663822);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0001ACD8 File Offset: 0x00018ED8
		public unsafe TMP_Text textField
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985529, XrefRangeEnd = 985536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersionNumberText.NativeMethodInfoPtr_get_textField_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0001AD18 File Offset: 0x00018F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985536, XrefRangeEnd = 985563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersionNumberText.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0001AD58 File Offset: 0x00018F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985563, XrefRangeEnd = 985571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerVersionNumberText()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerVersionNumberText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersionNumberText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0001AD94 File Offset: 0x00018F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985571, XrefRangeEnd = 985587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__4_0(string versionStr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(versionStr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerVersionNumberText.NativeMethodInfoPtr__Start_b__4_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000034C9 File Offset: 0x000016C9
		public ServerVersionNumberText(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0001ADD8 File Offset: 0x00018FD8
		// (set) Token: 0x0600030B RID: 779 RVA: 0x000034D2 File Offset: 0x000016D2
		public unsafe string client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersionNumberText.NativeFieldInfoPtr_client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersionNumberText.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0001AE00 File Offset: 0x00019000
		// (set) Token: 0x0600030D RID: 781 RVA: 0x000034F1 File Offset: 0x000016F1
		public unsafe string prefixLocaleKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersionNumberText.NativeFieldInfoPtr_prefixLocaleKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerVersionNumberText.NativeFieldInfoPtr_prefixLocaleKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_client;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_prefixLocaleKey;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_get_textField_Public_get_TMP_Text_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_0_Private_Void_String_0;
	}
}
