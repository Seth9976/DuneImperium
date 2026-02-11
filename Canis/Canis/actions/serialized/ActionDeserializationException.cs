using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions.serialized
{
	// Token: 0x02000212 RID: 530
	public class ActionDeserializationException : Exception
	{
		// Token: 0x06001653 RID: 5715 RVA: 0x00073024 File Offset: 0x00071224
		// Note: this type is marked as 'beforefieldinit'.
		static ActionDeserializationException()
		{
			Il2CppClassPointerStore<ActionDeserializationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.serialized", "ActionDeserializationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionDeserializationException>.NativeClassPtr);
			ActionDeserializationException.NativeFieldInfoPtr_SerializedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionDeserializationException>.NativeClassPtr, "SerializedAction");
			ActionDeserializationException.NativeMethodInfoPtr_MakeMessage_Private_Static_String_SerializedAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDeserializationException>.NativeClassPtr, 100668383);
			ActionDeserializationException.NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDeserializationException>.NativeClassPtr, 100668384);
			ActionDeserializationException.NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDeserializationException>.NativeClassPtr, 100668385);
			ActionDeserializationException.NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionDeserializationException>.NativeClassPtr, 100668386);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x000730B8 File Offset: 0x000712B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593348, XrefRangeEnd = 593354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakeMessage(SerializedAction serializedAction, string message = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDeserializationException.NativeMethodInfoPtr_MakeMessage_Private_Static_String_SerializedAction_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00073108 File Offset: 0x00071308
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 593363, RefRangeEnd = 593367, XrefRangeStart = 593354, XrefRangeEnd = 593363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionDeserializationException(SerializedAction serializedAction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionDeserializationException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDeserializationException.NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00073154 File Offset: 0x00071354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593367, XrefRangeEnd = 593379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionDeserializationException(SerializedAction serializedAction, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionDeserializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDeserializationException.NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x000731B4 File Offset: 0x000713B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593379, XrefRangeEnd = 593391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionDeserializationException(SerializedAction serializedAction, string message, Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionDeserializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionDeserializationException.NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0000ABED File Offset: 0x00008DED
		public ActionDeserializationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00073224 File Offset: 0x00071424
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x0000ABF6 File Offset: 0x00008DF6
		public unsafe SerializedAction SerializedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionDeserializationException.NativeFieldInfoPtr_SerializedAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionDeserializationException.NativeFieldInfoPtr_SerializedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeFieldInfoPtr_SerializedAction;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_MakeMessage_Private_Static_String_SerializedAction_String_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_String_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedAction_String_Exception_0;
	}
}
