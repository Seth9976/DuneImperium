using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.EventSystems;

namespace dwd.core.input.compositeModule.activation
{
	// Token: 0x020000A2 RID: 162
	public class ModuleActivator : UIBehaviour
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x0001EF50 File Offset: 0x0001D150
		// Note: this type is marked as 'beforefieldinit'.
		static ModuleActivator()
		{
			Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.activation", "ModuleActivator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr);
			ModuleActivator.NativeFieldInfoPtr_activationStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr, "activationStrategy");
			ModuleActivator.NativeFieldInfoPtr_CanActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr, "CanActivate");
			ModuleActivator.NativeFieldInfoPtr_forceActivationNextQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr, "forceActivationNextQuery");
			ModuleActivator.NativeMethodInfoPtr_get_StrategyName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr, 100664213);
			ModuleActivator.NativeMethodInfoPtr_ShouldModuleActivate_Public_Virtual_Final_New_Boolean_InputDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr, 100664214);
			ModuleActivator.NativeMethodInfoPtr_ForceActivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr, 100664215);
			ModuleActivator.NativeMethodInfoPtr_Activated_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr, 100664216);
			ModuleActivator.NativeMethodInfoPtr_Deactivated_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr, 100664217);
			ModuleActivator.NativeMethodInfoPtr_shouldModuleActivate_Protected_Abstract_Virtual_New_Boolean_InputDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr, 100664218);
			ModuleActivator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr, 100664219);
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x0001F048 File Offset: 0x0001D248
		public unsafe virtual string StrategyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleActivator.NativeMethodInfoPtr_get_StrategyName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0001F080 File Offset: 0x0001D280
		[CallerCount(0)]
		public unsafe virtual bool ShouldModuleActivate(InputDetector inputDetector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleActivator.NativeMethodInfoPtr_ShouldModuleActivate_Public_Virtual_Final_New_Boolean_InputDetector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0001F0D0 File Offset: 0x0001D2D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 440597, RefRangeEnd = 440599, XrefRangeStart = 440597, XrefRangeEnd = 440599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleActivator.NativeMethodInfoPtr_ForceActivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0001F104 File Offset: 0x0001D304
		[CallerCount(0)]
		public unsafe virtual void Activated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModuleActivator.NativeMethodInfoPtr_Activated_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0001F140 File Offset: 0x0001D340
		[CallerCount(0)]
		public unsafe virtual void Deactivated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModuleActivator.NativeMethodInfoPtr_Deactivated_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0001F17C File Offset: 0x0001D37C
		[CallerCount(0)]
		public unsafe virtual bool shouldModuleActivate(InputDetector inputDetector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModuleActivator.NativeMethodInfoPtr_shouldModuleActivate_Protected_Abstract_Virtual_New_Boolean_InputDetector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0001F1D4 File Offset: 0x0001D3D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1126492, RefRangeEnd = 1126493, XrefRangeStart = 1126492, XrefRangeEnd = 1126493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModuleActivator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModuleActivator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModuleActivator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00005DA3 File Offset: 0x00003FA3
		public ModuleActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0001F210 File Offset: 0x0001D410
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00005DAC File Offset: 0x00003FAC
		public unsafe string activationStrategy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModuleActivator.NativeFieldInfoPtr_activationStrategy);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModuleActivator.NativeFieldInfoPtr_activationStrategy), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x0001F238 File Offset: 0x0001D438
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00005DCB File Offset: 0x00003FCB
		public unsafe bool CanActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModuleActivator.NativeFieldInfoPtr_CanActivate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModuleActivator.NativeFieldInfoPtr_CanActivate)) = value;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0001F260 File Offset: 0x0001D460
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00005DE6 File Offset: 0x00003FE6
		public unsafe bool forceActivationNextQuery
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModuleActivator.NativeFieldInfoPtr_forceActivationNextQuery);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModuleActivator.NativeFieldInfoPtr_forceActivationNextQuery)) = value;
			}
		}

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr_activationStrategy;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_CanActivate;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr_forceActivationNextQuery;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_get_StrategyName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_ShouldModuleActivate_Public_Virtual_Final_New_Boolean_InputDetector_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_ForceActivate_Public_Void_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_Activated_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_Deactivated_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_shouldModuleActivate_Protected_Abstract_Virtual_New_Boolean_InputDetector_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
