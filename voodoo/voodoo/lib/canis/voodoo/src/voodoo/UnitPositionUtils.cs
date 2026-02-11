using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;

namespace lib.canis.voodoo.src.voodoo
{
	// Token: 0x0200000F RID: 15
	public static class UnitPositionUtils : global::Il2CppSystem.Object
	{
		// Token: 0x0600007B RID: 123 RVA: 0x000024D8 File Offset: 0x000006D8
		// Note: this type is marked as 'beforefieldinit'.
		static UnitPositionUtils()
		{
			Il2CppClassPointerStore<UnitPositionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.canis.voodoo.src.voodoo", "UnitPositionUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitPositionUtils>.NativeClassPtr);
			UnitPositionUtils.NativeMethodInfoPtr_CreateOrUpdatePosition_Public_Static_UnitPosition_UnitView_Int32_Object_LocalTransform_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPositionUtils>.NativeClassPtr, 100663358);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000A914 File Offset: 0x00008B14
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1106793, RefRangeEnd = 1106804, XrefRangeStart = 1106788, XrefRangeEnd = 1106793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnitPosition CreateOrUpdatePosition(this UnitView unitView, int moveLayer, global::Il2CppSystem.Object requester, LocalTransform localTransform, Transform parent, bool show = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unitView);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveLayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requester);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localTransform;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref show;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitPositionUtils.NativeMethodInfoPtr_CreateOrUpdatePosition_Public_Static_UnitPosition_UnitView_Int32_Object_LocalTransform_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnitPosition>(intPtr3) : null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002511 File Offset: 0x00000711
		public UnitPositionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_CreateOrUpdatePosition_Public_Static_UnitPosition_UnitView_Int32_Object_LocalTransform_Transform_Boolean_0;
	}
}
