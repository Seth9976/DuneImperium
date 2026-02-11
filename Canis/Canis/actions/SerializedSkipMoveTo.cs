using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x020001C6 RID: 454
	public class SerializedSkipMoveTo : SerializedAction
	{
		// Token: 0x06001333 RID: 4915 RVA: 0x00066FA0 File Offset: 0x000651A0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSkipMoveTo()
		{
			Il2CppClassPointerStore<SerializedSkipMoveTo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedSkipMoveTo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSkipMoveTo>.NativeClassPtr);
			SerializedSkipMoveTo.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipMoveTo>.NativeClassPtr, 100667439);
			SerializedSkipMoveTo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSkipMoveTo>.NativeClassPtr, 100667440);
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00066FF8 File Offset: 0x000651F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586548, XrefRangeEnd = 586553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedSkipMoveTo.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00067054 File Offset: 0x00065254
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSkipMoveTo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSkipMoveTo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSkipMoveTo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x000096C2 File Offset: 0x000078C2
		public SerializedSkipMoveTo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
