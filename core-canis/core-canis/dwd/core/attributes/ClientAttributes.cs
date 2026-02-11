using System;
using Canis.attributes;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.attributes
{
	// Token: 0x02000213 RID: 531
	public static class ClientAttributes : Object
	{
		// Token: 0x06001D11 RID: 7441 RVA: 0x00086DA4 File Offset: 0x00084FA4
		// Note: this type is marked as 'beforefieldinit'.
		static ClientAttributes()
		{
			Il2CppClassPointerStore<ClientAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.attributes", "ClientAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAttributes>.NativeClassPtr);
			ClientAttributes.NativeFieldInfoPtr_ConfirmButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAttributes>.NativeClassPtr, "ConfirmButtonText");
			ClientAttributes.NativeFieldInfoPtr_DenyButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAttributes>.NativeClassPtr, "DenyButtonText");
			ClientAttributes.NativeFieldInfoPtr_TemporaryEntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAttributes>.NativeClassPtr, "TemporaryEntityName");
			ClientAttributes.NativeFieldInfoPtr_BoolTransformResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAttributes>.NativeClassPtr, "BoolTransformResult");
			ClientAttributes.NativeFieldInfoPtr_BoolTransformResult2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAttributes>.NativeClassPtr, "BoolTransformResult2");
			ClientAttributes.NativeFieldInfoPtr_IntTransformResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAttributes>.NativeClassPtr, "IntTransformResult");
			ClientAttributes.NativeFieldInfoPtr_IntListTransformResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientAttributes>.NativeClassPtr, "IntListTransformResult");
			ClientAttributes.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAttributes>.NativeClassPtr, 100667982);
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00086E74 File Offset: 0x00085074
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientAttributes.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0000C67B File Offset: 0x0000A87B
		public ClientAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00086E9C File Offset: 0x0008509C
		// (set) Token: 0x06001D15 RID: 7445 RVA: 0x0000C684 File Offset: 0x0000A884
		public unsafe static AttributeDefinition<LocalizableText> ConfirmButtonText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClientAttributes.NativeFieldInfoPtr_ConfirmButtonText, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientAttributes.NativeFieldInfoPtr_ConfirmButtonText, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x00086EC4 File Offset: 0x000850C4
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x0000C696 File Offset: 0x0000A896
		public unsafe static AttributeDefinition<LocalizableText> DenyButtonText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClientAttributes.NativeFieldInfoPtr_DenyButtonText, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientAttributes.NativeFieldInfoPtr_DenyButtonText, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x00086EEC File Offset: 0x000850EC
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		public unsafe static AttributeDefinition<string> TemporaryEntityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClientAttributes.NativeFieldInfoPtr_TemporaryEntityName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientAttributes.NativeFieldInfoPtr_TemporaryEntityName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x00086F14 File Offset: 0x00085114
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x0000C6BA File Offset: 0x0000A8BA
		public unsafe static AttributeDefinition<Nullable<bool>> BoolTransformResult
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClientAttributes.NativeFieldInfoPtr_BoolTransformResult, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientAttributes.NativeFieldInfoPtr_BoolTransformResult, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00086F3C File Offset: 0x0008513C
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x0000C6CC File Offset: 0x0000A8CC
		public unsafe static AttributeDefinition<Nullable<bool>> BoolTransformResult2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClientAttributes.NativeFieldInfoPtr_BoolTransformResult2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientAttributes.NativeFieldInfoPtr_BoolTransformResult2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00086F64 File Offset: 0x00085164
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x0000C6DE File Offset: 0x0000A8DE
		public unsafe static AttributeDefinition<Nullable<int>> IntTransformResult
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClientAttributes.NativeFieldInfoPtr_IntTransformResult, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientAttributes.NativeFieldInfoPtr_IntTransformResult, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00086F8C File Offset: 0x0008518C
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		public unsafe static AttributeDefinition<Il2CppStructArray<int>> IntListTransformResult
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClientAttributes.NativeFieldInfoPtr_IntListTransformResult, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientAttributes.NativeFieldInfoPtr_IntListTransformResult, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmButtonText;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeFieldInfoPtr_DenyButtonText;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeFieldInfoPtr_TemporaryEntityName;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeFieldInfoPtr_BoolTransformResult;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeFieldInfoPtr_BoolTransformResult2;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeFieldInfoPtr_IntTransformResult;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeFieldInfoPtr_IntListTransformResult;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;
	}
}
