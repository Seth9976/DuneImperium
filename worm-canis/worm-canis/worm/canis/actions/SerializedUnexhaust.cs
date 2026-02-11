using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x020002A6 RID: 678
	public class SerializedUnexhaust : SerializedAction
	{
		// Token: 0x06001C1C RID: 7196 RVA: 0x000C6194 File Offset: 0x000C4394
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedUnexhaust()
		{
			Il2CppClassPointerStore<SerializedUnexhaust>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedUnexhaust");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedUnexhaust>.NativeClassPtr);
			SerializedUnexhaust.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedUnexhaust>.NativeClassPtr, 100669019);
			SerializedUnexhaust.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedUnexhaust>.NativeClassPtr, 100669020);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x000C61EC File Offset: 0x000C43EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149569, XrefRangeEnd = 149573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedUnexhaust.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x000C6248 File Offset: 0x000C4448
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedUnexhaust()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedUnexhaust>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedUnexhaust.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0000BF34 File Offset: 0x0000A134
		public SerializedUnexhaust(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
