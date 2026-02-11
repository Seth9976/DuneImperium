using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.context
{
	// Token: 0x02000118 RID: 280
	public static class CoreContextParameters : Object
	{
		// Token: 0x06000CBC RID: 3260 RVA: 0x000506A4 File Offset: 0x0004E8A4
		// Note: this type is marked as 'beforefieldinit'.
		static CoreContextParameters()
		{
			Il2CppClassPointerStore<CoreContextParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context", "CoreContextParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreContextParameters>.NativeClassPtr);
			CoreContextParameters.NativeFieldInfoPtr_AttributeDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreContextParameters>.NativeClassPtr, "AttributeDefinition");
			CoreContextParameters.NativeFieldInfoPtr_AttributeDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreContextParameters>.NativeClassPtr, "AttributeDelta");
			CoreContextParameters.NativeFieldInfoPtr_UndoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreContextParameters>.NativeClassPtr, "UndoNode");
			CoreContextParameters.NativeFieldInfoPtr_SourcePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreContextParameters>.NativeClassPtr, "SourcePlayer");
			CoreContextParameters.NativeFieldInfoPtr_ActiveAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreContextParameters>.NativeClassPtr, "ActiveAbility");
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00006753 File Offset: 0x00004953
		public CoreContextParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00050738 File Offset: 0x0004E938
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x0000675C File Offset: 0x0000495C
		public unsafe static string AttributeDefinition
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreContextParameters.NativeFieldInfoPtr_AttributeDefinition, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreContextParameters.NativeFieldInfoPtr_AttributeDefinition, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00050758 File Offset: 0x0004E958
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x0000676E File Offset: 0x0000496E
		public unsafe static string AttributeDelta
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreContextParameters.NativeFieldInfoPtr_AttributeDelta, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreContextParameters.NativeFieldInfoPtr_AttributeDelta, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00050778 File Offset: 0x0004E978
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00006780 File Offset: 0x00004980
		public unsafe static string UndoNode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreContextParameters.NativeFieldInfoPtr_UndoNode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreContextParameters.NativeFieldInfoPtr_UndoNode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00050798 File Offset: 0x0004E998
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x00006792 File Offset: 0x00004992
		public unsafe static string SourcePlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreContextParameters.NativeFieldInfoPtr_SourcePlayer, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreContextParameters.NativeFieldInfoPtr_SourcePlayer, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x000507B8 File Offset: 0x0004E9B8
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x000067A4 File Offset: 0x000049A4
		public unsafe static string ActiveAbility
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreContextParameters.NativeFieldInfoPtr_ActiveAbility, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreContextParameters.NativeFieldInfoPtr_ActiveAbility, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr_AttributeDefinition;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeFieldInfoPtr_AttributeDelta;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeFieldInfoPtr_UndoNode;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeFieldInfoPtr_SourcePlayer;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAbility;
	}
}
