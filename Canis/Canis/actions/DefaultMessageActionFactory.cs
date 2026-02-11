using System;
using Canis.entities;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions
{
	// Token: 0x02000177 RID: 375
	public class DefaultMessageActionFactory : Object
	{
		// Token: 0x060010B8 RID: 4280 RVA: 0x0005D7E4 File Offset: 0x0005B9E4
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultMessageActionFactory()
		{
			Il2CppClassPointerStore<DefaultMessageActionFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "DefaultMessageActionFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultMessageActionFactory>.NativeClassPtr);
			DefaultMessageActionFactory.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_Action_NetworkMessageEvent_Match_PlayerEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMessageActionFactory>.NativeClassPtr, 100666760);
			DefaultMessageActionFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMessageActionFactory>.NativeClassPtr, 100666761);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0005D83C File Offset: 0x0005BA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582563, XrefRangeEnd = 582570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Action Create(NetworkMessageEvent message, Match m, PlayerEntity player, bool waitForResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultMessageActionFactory.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_Action_NetworkMessageEvent_Match_PlayerEntity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0005D8C0 File Offset: 0x0005BAC0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultMessageActionFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultMessageActionFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultMessageActionFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00008607 File Offset: 0x00006807
		public DefaultMessageActionFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Final_New_Action_NetworkMessageEvent_Match_PlayerEntity_Boolean_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
