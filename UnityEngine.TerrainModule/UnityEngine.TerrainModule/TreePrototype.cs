using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public sealed class TreePrototype
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002DEF File Offset: 0x00000FEF
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002DFC File Offset: 0x00000FFC
		public GameObject prefab
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002E09 File Offset: 0x00001009
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002E16 File Offset: 0x00001016
		public float bendFactor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00002E23 File Offset: 0x00001023
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002E30 File Offset: 0x00001030
		public int navMeshLod
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00005DE8 File Offset: 0x00003FE8
		public override bool Equals(Object obj)
		{
			return this.Equals(obj.TryCast<TreePrototype>());
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00005E08 File Offset: 0x00004008
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005E20 File Offset: 0x00004020
		public bool Equals(TreePrototype other)
		{
			bool flag = other == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = other == this;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = base.GetType() != other.GetType();
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.prefab == other.prefab && this.bendFactor == other.bendFactor && this.navMeshLod == other.navMeshLod;
						flag2 = flag5;
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002E3D File Offset: 0x0000103D
		public bool Validate(out string errorMessage)
		{
			return TreePrototype.ValidateTreePrototype(this, out errorMessage);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005E9C File Offset: 0x0000409C
		public unsafe static bool ValidateTreePrototype(TreePrototype prototype, out string errorMessage)
		{
			TreePrototype.ValidateTreePrototypeDelegate validateTreePrototypeDelegateField = TreePrototype.ValidateTreePrototypeDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(prototype);
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
			return validateTreePrototypeDelegateField(intPtr, &intPtr2);
		}

		// Token: 0x040000EF RID: 239
		private static readonly TreePrototype.ValidateTreePrototypeDelegate ValidateTreePrototypeDelegateField = IL2CPP.ResolveICall<TreePrototype.ValidateTreePrototypeDelegate>("UnityEngine.TreePrototype::ValidateTreePrototype");

		// Token: 0x020000C6 RID: 198
		// (Invoke) Token: 0x06000356 RID: 854
		private delegate bool ValidateTreePrototypeDelegate(IntPtr prototype, [Out] IntPtr errorMessage);
	}
}
