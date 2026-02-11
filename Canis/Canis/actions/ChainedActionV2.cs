using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x0200019D RID: 413
	public class ChainedActionV2 : WrappedAction
	{
		// Token: 0x060011FA RID: 4602 RVA: 0x0006228C File Offset: 0x0006048C
		// Note: this type is marked as 'beforefieldinit'.
		static ChainedActionV2()
		{
			Il2CppClassPointerStore<ChainedActionV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ChainedActionV2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChainedActionV2>.NativeClassPtr);
			ChainedActionV2.NativeMethodInfoPtr__ctor_Public_Void_Match_Il2CppReferenceArray_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainedActionV2>.NativeClassPtr, 100667108);
			ChainedActionV2.NativeMethodInfoPtr__ctor_Public_Void_Match_SerializedWrappedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainedActionV2>.NativeClassPtr, 100667109);
			ChainedActionV2.NativeMethodInfoPtr_MakeSerializedWrappedAction_Protected_Virtual_SerializedWrappedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainedActionV2>.NativeClassPtr, 100667110);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x000622F8 File Offset: 0x000604F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584762, XrefRangeEnd = 584763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChainedActionV2(Match m, [Optional] Il2CppReferenceArray<Action> wrappedActions)
		{
			if (wrappedActions == null)
			{
				wrappedActions = new Il2CppReferenceArray<Action>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChainedActionV2>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wrappedActions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainedActionV2.NativeMethodInfoPtr__ctor_Public_Void_Match_Il2CppReferenceArray_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00062364 File Offset: 0x00060564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584763, XrefRangeEnd = 584764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChainedActionV2(Match m, SerializedWrappedAction serialized)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChainedActionV2>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainedActionV2.NativeMethodInfoPtr__ctor_Public_Void_Match_SerializedWrappedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x000623C4 File Offset: 0x000605C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584764, XrefRangeEnd = 584768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedWrappedAction MakeSerializedWrappedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainedActionV2.NativeMethodInfoPtr_MakeSerializedWrappedAction_Protected_Virtual_SerializedWrappedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedWrappedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00008ED4 File Offset: 0x000070D4
		public ChainedActionV2(Match m, params Action[] wrappedActions)
			: this(m, new Il2CppReferenceArray<Action>(wrappedActions))
		{
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00008EE3 File Offset: 0x000070E3
		public ChainedActionV2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Il2CppReferenceArray_1_Action_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_SerializedWrappedAction_0;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedWrappedAction_Protected_Virtual_SerializedWrappedAction_Match_0;
	}
}
