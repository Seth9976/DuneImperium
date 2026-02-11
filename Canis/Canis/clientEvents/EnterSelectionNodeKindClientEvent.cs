using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.clientevents;

namespace Canis.clientEvents
{
	// Token: 0x0200015C RID: 348
	public class EnterSelectionNodeKindClientEvent : ClientEvent
	{
		// Token: 0x06000F62 RID: 3938 RVA: 0x000590B8 File Offset: 0x000572B8
		// Note: this type is marked as 'beforefieldinit'.
		static EnterSelectionNodeKindClientEvent()
		{
			Il2CppClassPointerStore<EnterSelectionNodeKindClientEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.clientEvents", "EnterSelectionNodeKindClientEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnterSelectionNodeKindClientEvent>.NativeClassPtr);
			EnterSelectionNodeKindClientEvent.NativeFieldInfoPtr_NodeKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnterSelectionNodeKindClientEvent>.NativeClassPtr, "NodeKind");
			EnterSelectionNodeKindClientEvent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnterSelectionNodeKindClientEvent>.NativeClassPtr, 100666535);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00059110 File Offset: 0x00057310
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnterSelectionNodeKindClientEvent(string nodeKind)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnterSelectionNodeKindClientEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(nodeKind);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnterSelectionNodeKindClientEvent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00007D40 File Offset: 0x00005F40
		public EnterSelectionNodeKindClientEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x0005915C File Offset: 0x0005735C
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x00007D49 File Offset: 0x00005F49
		public unsafe string NodeKind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterSelectionNodeKindClientEvent.NativeFieldInfoPtr_NodeKind);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnterSelectionNodeKindClientEvent.NativeFieldInfoPtr_NodeKind), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_NodeKind;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
