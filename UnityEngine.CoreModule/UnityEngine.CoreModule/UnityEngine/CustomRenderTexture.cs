using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000E8 RID: 232
	public sealed class CustomRenderTexture : RenderTexture
	{
		// Token: 0x0600125C RID: 4700 RVA: 0x0005CDA8 File Offset: 0x0005AFA8
		// Note: this type is marked as 'beforefieldinit'.
		static CustomRenderTexture()
		{
			Il2CppClassPointerStore<CustomRenderTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CustomRenderTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderTexture>.NativeClassPtr);
			CustomRenderTexture.Internal_CreateCustomRenderTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.Internal_CreateCustomRenderTextureDelegate>("UnityEngine.CustomRenderTexture::Internal_CreateCustomRenderTexture");
			CustomRenderTexture.TriggerUpdateDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.TriggerUpdateDelegate>("UnityEngine.CustomRenderTexture::TriggerUpdate");
			CustomRenderTexture.TriggerInitializationDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.TriggerInitializationDelegate>("UnityEngine.CustomRenderTexture::TriggerInitialization");
			CustomRenderTexture.ClearUpdateZonesDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.ClearUpdateZonesDelegate>("UnityEngine.CustomRenderTexture::ClearUpdateZones");
			CustomRenderTexture.get_materialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_materialDelegate>("UnityEngine.CustomRenderTexture::get_material");
			CustomRenderTexture.set_materialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_materialDelegate>("UnityEngine.CustomRenderTexture::set_material");
			CustomRenderTexture.get_initializationMaterialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationMaterialDelegate>("UnityEngine.CustomRenderTexture::get_initializationMaterial");
			CustomRenderTexture.set_initializationMaterialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationMaterialDelegate>("UnityEngine.CustomRenderTexture::set_initializationMaterial");
			CustomRenderTexture.get_initializationTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationTextureDelegate>("UnityEngine.CustomRenderTexture::get_initializationTexture");
			CustomRenderTexture.set_initializationTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationTextureDelegate>("UnityEngine.CustomRenderTexture::set_initializationTexture");
			CustomRenderTexture.GetUpdateZonesInternalDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.GetUpdateZonesInternalDelegate>("UnityEngine.CustomRenderTexture::GetUpdateZonesInternal");
			CustomRenderTexture.GetDoubleBufferRenderTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.GetDoubleBufferRenderTextureDelegate>("UnityEngine.CustomRenderTexture::GetDoubleBufferRenderTexture");
			CustomRenderTexture.EnsureDoubleBufferConsistencyDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.EnsureDoubleBufferConsistencyDelegate>("UnityEngine.CustomRenderTexture::EnsureDoubleBufferConsistency");
			CustomRenderTexture.get_initializationSourceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationSourceDelegate>("UnityEngine.CustomRenderTexture::get_initializationSource");
			CustomRenderTexture.set_initializationSourceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationSourceDelegate>("UnityEngine.CustomRenderTexture::set_initializationSource");
			CustomRenderTexture.get_updateModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updateModeDelegate>("UnityEngine.CustomRenderTexture::get_updateMode");
			CustomRenderTexture.set_updateModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updateModeDelegate>("UnityEngine.CustomRenderTexture::set_updateMode");
			CustomRenderTexture.get_initializationModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationModeDelegate>("UnityEngine.CustomRenderTexture::get_initializationMode");
			CustomRenderTexture.set_initializationModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationModeDelegate>("UnityEngine.CustomRenderTexture::set_initializationMode");
			CustomRenderTexture.get_updateZoneSpaceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updateZoneSpaceDelegate>("UnityEngine.CustomRenderTexture::get_updateZoneSpace");
			CustomRenderTexture.set_updateZoneSpaceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updateZoneSpaceDelegate>("UnityEngine.CustomRenderTexture::set_updateZoneSpace");
			CustomRenderTexture.get_shaderPassDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_shaderPassDelegate>("UnityEngine.CustomRenderTexture::get_shaderPass");
			CustomRenderTexture.set_shaderPassDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_shaderPassDelegate>("UnityEngine.CustomRenderTexture::set_shaderPass");
			CustomRenderTexture.get_cubemapFaceMaskDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_cubemapFaceMaskDelegate>("UnityEngine.CustomRenderTexture::get_cubemapFaceMask");
			CustomRenderTexture.set_cubemapFaceMaskDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_cubemapFaceMaskDelegate>("UnityEngine.CustomRenderTexture::set_cubemapFaceMask");
			CustomRenderTexture.get_doubleBufferedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_doubleBufferedDelegate>("UnityEngine.CustomRenderTexture::get_doubleBuffered");
			CustomRenderTexture.set_doubleBufferedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_doubleBufferedDelegate>("UnityEngine.CustomRenderTexture::set_doubleBuffered");
			CustomRenderTexture.get_wrapUpdateZonesDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_wrapUpdateZonesDelegate>("UnityEngine.CustomRenderTexture::get_wrapUpdateZones");
			CustomRenderTexture.set_wrapUpdateZonesDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_wrapUpdateZonesDelegate>("UnityEngine.CustomRenderTexture::set_wrapUpdateZones");
			CustomRenderTexture.get_updatePeriodDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updatePeriodDelegate>("UnityEngine.CustomRenderTexture::get_updatePeriod");
			CustomRenderTexture.set_updatePeriodDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updatePeriodDelegate>("UnityEngine.CustomRenderTexture::set_updatePeriod");
			CustomRenderTexture.get_initializationColor_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationColor_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationColor_Injected");
			CustomRenderTexture.set_initializationColor_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationColor_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationColor_Injected");
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00007B23 File Offset: 0x00005D23
		public CustomRenderTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00007B2C File Offset: 0x00005D2C
		public static void Internal_CreateCustomRenderTexture(CustomRenderTexture rt)
		{
			CustomRenderTexture.Internal_CreateCustomRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rt));
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00007B3E File Offset: 0x00005D3E
		public void TriggerUpdate(int count)
		{
			CustomRenderTexture.TriggerUpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), count);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00007B51 File Offset: 0x00005D51
		public void Update(int count)
		{
			CustomRenderTextureManager.InvokeTriggerUpdate(this, count);
			this.TriggerUpdate(count);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00007B64 File Offset: 0x00005D64
		public void Update()
		{
			this.Update(1);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00007B6F File Offset: 0x00005D6F
		public void TriggerInitialization()
		{
			CustomRenderTexture.TriggerInitializationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00007B81 File Offset: 0x00005D81
		public void Initialize()
		{
			this.TriggerInitialization();
			CustomRenderTextureManager.InvokeTriggerInitialize(this);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00007B92 File Offset: 0x00005D92
		public void ClearUpdateZones()
		{
			CustomRenderTexture.ClearUpdateZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x0005CFC8 File Offset: 0x0005B1C8
		// (set) Token: 0x06001266 RID: 4710 RVA: 0x00007BA4 File Offset: 0x00005DA4
		public Material material
		{
			get
			{
				IntPtr intPtr = CustomRenderTexture.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				CustomRenderTexture.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x0005CFF4 File Offset: 0x0005B1F4
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x00007BBC File Offset: 0x00005DBC
		public Material initializationMaterial
		{
			get
			{
				IntPtr intPtr = CustomRenderTexture.get_initializationMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				CustomRenderTexture.set_initializationMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x0005D020 File Offset: 0x0005B220
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x00007BD4 File Offset: 0x00005DD4
		public Texture initializationTexture
		{
			get
			{
				IntPtr intPtr = CustomRenderTexture.get_initializationTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				CustomRenderTexture.set_initializationTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00007BEC File Offset: 0x00005DEC
		public void GetUpdateZonesInternal(Object updateZones)
		{
			CustomRenderTexture.GetUpdateZonesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(updateZones));
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0005D04C File Offset: 0x0005B24C
		public RenderTexture GetDoubleBufferRenderTexture()
		{
			IntPtr intPtr = CustomRenderTexture.GetDoubleBufferRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00007C04 File Offset: 0x00005E04
		public void EnsureDoubleBufferConsistency()
		{
			CustomRenderTexture.EnsureDoubleBufferConsistencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x00007C16 File Offset: 0x00005E16
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x00007C28 File Offset: 0x00005E28
		public CustomRenderTextureInitializationSource initializationSource
		{
			get
			{
				return CustomRenderTexture.get_initializationSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_initializationSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x0005D078 File Offset: 0x0005B278
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x00007C3B File Offset: 0x00005E3B
		public Color initializationColor
		{
			get
			{
				Color color;
				this.get_initializationColor_Injected(out color);
				return color;
			}
			set
			{
				this.set_initializationColor_Injected(ref value);
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x00007C45 File Offset: 0x00005E45
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x00007C57 File Offset: 0x00005E57
		public CustomRenderTextureUpdateMode updateMode
		{
			get
			{
				return CustomRenderTexture.get_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x00007C6A File Offset: 0x00005E6A
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x00007C7C File Offset: 0x00005E7C
		public CustomRenderTextureUpdateMode initializationMode
		{
			get
			{
				return CustomRenderTexture.get_initializationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_initializationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x00007C8F File Offset: 0x00005E8F
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x00007CA1 File Offset: 0x00005EA1
		public CustomRenderTextureUpdateZoneSpace updateZoneSpace
		{
			get
			{
				return CustomRenderTexture.get_updateZoneSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_updateZoneSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00007CB4 File Offset: 0x00005EB4
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x00007CC6 File Offset: 0x00005EC6
		public int shaderPass
		{
			get
			{
				return CustomRenderTexture.get_shaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_shaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x00007CD9 File Offset: 0x00005ED9
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x00007CEB File Offset: 0x00005EEB
		public uint cubemapFaceMask
		{
			get
			{
				return CustomRenderTexture.get_cubemapFaceMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_cubemapFaceMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x00007CFE File Offset: 0x00005EFE
		// (set) Token: 0x0600127D RID: 4733 RVA: 0x00007D10 File Offset: 0x00005F10
		public bool doubleBuffered
		{
			get
			{
				return CustomRenderTexture.get_doubleBufferedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_doubleBufferedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x00007D23 File Offset: 0x00005F23
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x00007D35 File Offset: 0x00005F35
		public bool wrapUpdateZones
		{
			get
			{
				return CustomRenderTexture.get_wrapUpdateZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_wrapUpdateZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x00007D48 File Offset: 0x00005F48
		// (set) Token: 0x06001281 RID: 4737 RVA: 0x00007D5A File Offset: 0x00005F5A
		public float updatePeriod
		{
			get
			{
				return CustomRenderTexture.get_updatePeriodDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_updatePeriodDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00007D6D File Offset: 0x00005F6D
		public void get_initializationColor_Injected(out Color ret)
		{
			CustomRenderTexture.get_initializationColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00007D80 File Offset: 0x00005F80
		public void set_initializationColor_Injected(ref Color value)
		{
			CustomRenderTexture.set_initializationColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04001034 RID: 4148
		private static readonly CustomRenderTexture.Internal_CreateCustomRenderTextureDelegate Internal_CreateCustomRenderTextureDelegateField;

		// Token: 0x04001035 RID: 4149
		private static readonly CustomRenderTexture.TriggerUpdateDelegate TriggerUpdateDelegateField;

		// Token: 0x04001036 RID: 4150
		private static readonly CustomRenderTexture.TriggerInitializationDelegate TriggerInitializationDelegateField;

		// Token: 0x04001037 RID: 4151
		private static readonly CustomRenderTexture.ClearUpdateZonesDelegate ClearUpdateZonesDelegateField;

		// Token: 0x04001038 RID: 4152
		private static readonly CustomRenderTexture.get_materialDelegate get_materialDelegateField;

		// Token: 0x04001039 RID: 4153
		private static readonly CustomRenderTexture.set_materialDelegate set_materialDelegateField;

		// Token: 0x0400103A RID: 4154
		private static readonly CustomRenderTexture.get_initializationMaterialDelegate get_initializationMaterialDelegateField;

		// Token: 0x0400103B RID: 4155
		private static readonly CustomRenderTexture.set_initializationMaterialDelegate set_initializationMaterialDelegateField;

		// Token: 0x0400103C RID: 4156
		private static readonly CustomRenderTexture.get_initializationTextureDelegate get_initializationTextureDelegateField;

		// Token: 0x0400103D RID: 4157
		private static readonly CustomRenderTexture.set_initializationTextureDelegate set_initializationTextureDelegateField;

		// Token: 0x0400103E RID: 4158
		private static readonly CustomRenderTexture.GetUpdateZonesInternalDelegate GetUpdateZonesInternalDelegateField;

		// Token: 0x0400103F RID: 4159
		private static readonly CustomRenderTexture.GetDoubleBufferRenderTextureDelegate GetDoubleBufferRenderTextureDelegateField;

		// Token: 0x04001040 RID: 4160
		private static readonly CustomRenderTexture.EnsureDoubleBufferConsistencyDelegate EnsureDoubleBufferConsistencyDelegateField;

		// Token: 0x04001041 RID: 4161
		private static readonly CustomRenderTexture.get_initializationSourceDelegate get_initializationSourceDelegateField;

		// Token: 0x04001042 RID: 4162
		private static readonly CustomRenderTexture.set_initializationSourceDelegate set_initializationSourceDelegateField;

		// Token: 0x04001043 RID: 4163
		private static readonly CustomRenderTexture.get_updateModeDelegate get_updateModeDelegateField;

		// Token: 0x04001044 RID: 4164
		private static readonly CustomRenderTexture.set_updateModeDelegate set_updateModeDelegateField;

		// Token: 0x04001045 RID: 4165
		private static readonly CustomRenderTexture.get_initializationModeDelegate get_initializationModeDelegateField;

		// Token: 0x04001046 RID: 4166
		private static readonly CustomRenderTexture.set_initializationModeDelegate set_initializationModeDelegateField;

		// Token: 0x04001047 RID: 4167
		private static readonly CustomRenderTexture.get_updateZoneSpaceDelegate get_updateZoneSpaceDelegateField;

		// Token: 0x04001048 RID: 4168
		private static readonly CustomRenderTexture.set_updateZoneSpaceDelegate set_updateZoneSpaceDelegateField;

		// Token: 0x04001049 RID: 4169
		private static readonly CustomRenderTexture.get_shaderPassDelegate get_shaderPassDelegateField;

		// Token: 0x0400104A RID: 4170
		private static readonly CustomRenderTexture.set_shaderPassDelegate set_shaderPassDelegateField;

		// Token: 0x0400104B RID: 4171
		private static readonly CustomRenderTexture.get_cubemapFaceMaskDelegate get_cubemapFaceMaskDelegateField;

		// Token: 0x0400104C RID: 4172
		private static readonly CustomRenderTexture.set_cubemapFaceMaskDelegate set_cubemapFaceMaskDelegateField;

		// Token: 0x0400104D RID: 4173
		private static readonly CustomRenderTexture.get_doubleBufferedDelegate get_doubleBufferedDelegateField;

		// Token: 0x0400104E RID: 4174
		private static readonly CustomRenderTexture.set_doubleBufferedDelegate set_doubleBufferedDelegateField;

		// Token: 0x0400104F RID: 4175
		private static readonly CustomRenderTexture.get_wrapUpdateZonesDelegate get_wrapUpdateZonesDelegateField;

		// Token: 0x04001050 RID: 4176
		private static readonly CustomRenderTexture.set_wrapUpdateZonesDelegate set_wrapUpdateZonesDelegateField;

		// Token: 0x04001051 RID: 4177
		private static readonly CustomRenderTexture.get_updatePeriodDelegate get_updatePeriodDelegateField;

		// Token: 0x04001052 RID: 4178
		private static readonly CustomRenderTexture.set_updatePeriodDelegate set_updatePeriodDelegateField;

		// Token: 0x04001053 RID: 4179
		private static readonly CustomRenderTexture.get_initializationColor_InjectedDelegate get_initializationColor_InjectedDelegateField;

		// Token: 0x04001054 RID: 4180
		private static readonly CustomRenderTexture.set_initializationColor_InjectedDelegate set_initializationColor_InjectedDelegateField;

		// Token: 0x020006B9 RID: 1721
		// (Invoke) Token: 0x06003650 RID: 13904
		private delegate void Internal_CreateCustomRenderTextureDelegate(IntPtr rt);

		// Token: 0x020006BA RID: 1722
		// (Invoke) Token: 0x06003652 RID: 13906
		private delegate void TriggerUpdateDelegate(IntPtr @this, int count);

		// Token: 0x020006BB RID: 1723
		// (Invoke) Token: 0x06003654 RID: 13908
		private delegate void TriggerInitializationDelegate(IntPtr @this);

		// Token: 0x020006BC RID: 1724
		// (Invoke) Token: 0x06003656 RID: 13910
		private delegate void ClearUpdateZonesDelegate(IntPtr @this);

		// Token: 0x020006BD RID: 1725
		// (Invoke) Token: 0x06003658 RID: 13912
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x020006BE RID: 1726
		// (Invoke) Token: 0x0600365A RID: 13914
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020006BF RID: 1727
		// (Invoke) Token: 0x0600365C RID: 13916
		private delegate IntPtr get_initializationMaterialDelegate(IntPtr @this);

		// Token: 0x020006C0 RID: 1728
		// (Invoke) Token: 0x0600365E RID: 13918
		private delegate void set_initializationMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020006C1 RID: 1729
		// (Invoke) Token: 0x06003660 RID: 13920
		private delegate IntPtr get_initializationTextureDelegate(IntPtr @this);

		// Token: 0x020006C2 RID: 1730
		// (Invoke) Token: 0x06003662 RID: 13922
		private delegate void set_initializationTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020006C3 RID: 1731
		// (Invoke) Token: 0x06003664 RID: 13924
		private delegate void GetUpdateZonesInternalDelegate(IntPtr @this, IntPtr updateZones);

		// Token: 0x020006C4 RID: 1732
		// (Invoke) Token: 0x06003666 RID: 13926
		private delegate IntPtr GetDoubleBufferRenderTextureDelegate(IntPtr @this);

		// Token: 0x020006C5 RID: 1733
		// (Invoke) Token: 0x06003668 RID: 13928
		private delegate void EnsureDoubleBufferConsistencyDelegate(IntPtr @this);

		// Token: 0x020006C6 RID: 1734
		// (Invoke) Token: 0x0600366A RID: 13930
		private delegate CustomRenderTextureInitializationSource get_initializationSourceDelegate(IntPtr @this);

		// Token: 0x020006C7 RID: 1735
		// (Invoke) Token: 0x0600366C RID: 13932
		private delegate void set_initializationSourceDelegate(IntPtr @this, CustomRenderTextureInitializationSource value);

		// Token: 0x020006C8 RID: 1736
		// (Invoke) Token: 0x0600366E RID: 13934
		private delegate CustomRenderTextureUpdateMode get_updateModeDelegate(IntPtr @this);

		// Token: 0x020006C9 RID: 1737
		// (Invoke) Token: 0x06003670 RID: 13936
		private delegate void set_updateModeDelegate(IntPtr @this, CustomRenderTextureUpdateMode value);

		// Token: 0x020006CA RID: 1738
		// (Invoke) Token: 0x06003672 RID: 13938
		private delegate CustomRenderTextureUpdateMode get_initializationModeDelegate(IntPtr @this);

		// Token: 0x020006CB RID: 1739
		// (Invoke) Token: 0x06003674 RID: 13940
		private delegate void set_initializationModeDelegate(IntPtr @this, CustomRenderTextureUpdateMode value);

		// Token: 0x020006CC RID: 1740
		// (Invoke) Token: 0x06003676 RID: 13942
		private delegate CustomRenderTextureUpdateZoneSpace get_updateZoneSpaceDelegate(IntPtr @this);

		// Token: 0x020006CD RID: 1741
		// (Invoke) Token: 0x06003678 RID: 13944
		private delegate void set_updateZoneSpaceDelegate(IntPtr @this, CustomRenderTextureUpdateZoneSpace value);

		// Token: 0x020006CE RID: 1742
		// (Invoke) Token: 0x0600367A RID: 13946
		private delegate int get_shaderPassDelegate(IntPtr @this);

		// Token: 0x020006CF RID: 1743
		// (Invoke) Token: 0x0600367C RID: 13948
		private delegate void set_shaderPassDelegate(IntPtr @this, int value);

		// Token: 0x020006D0 RID: 1744
		// (Invoke) Token: 0x0600367E RID: 13950
		private delegate uint get_cubemapFaceMaskDelegate(IntPtr @this);

		// Token: 0x020006D1 RID: 1745
		// (Invoke) Token: 0x06003680 RID: 13952
		private delegate void set_cubemapFaceMaskDelegate(IntPtr @this, uint value);

		// Token: 0x020006D2 RID: 1746
		// (Invoke) Token: 0x06003682 RID: 13954
		private delegate bool get_doubleBufferedDelegate(IntPtr @this);

		// Token: 0x020006D3 RID: 1747
		// (Invoke) Token: 0x06003684 RID: 13956
		private delegate void set_doubleBufferedDelegate(IntPtr @this, bool value);

		// Token: 0x020006D4 RID: 1748
		// (Invoke) Token: 0x06003686 RID: 13958
		private delegate bool get_wrapUpdateZonesDelegate(IntPtr @this);

		// Token: 0x020006D5 RID: 1749
		// (Invoke) Token: 0x06003688 RID: 13960
		private delegate void set_wrapUpdateZonesDelegate(IntPtr @this, bool value);

		// Token: 0x020006D6 RID: 1750
		// (Invoke) Token: 0x0600368A RID: 13962
		private delegate float get_updatePeriodDelegate(IntPtr @this);

		// Token: 0x020006D7 RID: 1751
		// (Invoke) Token: 0x0600368C RID: 13964
		private delegate void set_updatePeriodDelegate(IntPtr @this, float value);

		// Token: 0x020006D8 RID: 1752
		// (Invoke) Token: 0x0600368E RID: 13966
		private delegate void get_initializationColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020006D9 RID: 1753
		// (Invoke) Token: 0x06003690 RID: 13968
		private delegate void set_initializationColor_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
